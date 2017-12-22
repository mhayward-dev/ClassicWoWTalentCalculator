
app.controller('talentCalculatorController', function ($scope, $timeout, talentCalculatorFactory, warcraftClassVm, rowAllocationArray, inspectedTalentVm) {
    $scope.classes = [];
    $scope.selectedClassId = 0;
    $scope.selectedClass = null;

    $scope.isInspectingTalent = false;
    $scope.inspectedTalent = null;
    $scope.talentTooltipPos = {
        top: 0,
        left: 0
    };

    $scope.availablePoints = 51;
    $scope.requiredLevel = 9;
    $scope.totalPointsPerSpec = [0, 0, 0];
    $scope.selectedTalents = [[], [], []];
    $scope.talentsWaitingUnlock = [];

    $scope.fetchClasses = function () {
        talentCalculatorFactory.getClasses()
            .then(function (response) {
                $scope.classes = response.data.map(warcraftClassVm.build);
                $scope.fetchSpecifications('Druid');

            }, function (error) {
                console.log(error);
            });
    };

    $scope.fetchSpecifications = function (className) {
        talentCalculatorFactory.getSpecifications(className)
            .then(function (response) {
                if ($scope.selectedClassId > 0) {
                    $scope.getClassById($scope.selectedClassId).isSelected = false;
                }

                var dto = response.data;
                $scope.selectedClass = warcraftClassVm.build(dto.selectedClass);

                $scope.getClassById($scope.selectedClass.id).isSelected = true;
                $scope.selectedClassId = $scope.selectedClass.id;

                resetTotalPoints();

            }, function (error) {
                console.log(error);
            });
    };

    $scope.getClassById = function (id) {
        var selectedClass = _.find($scope.classes, { 'id': id });
        if (selectedClass) return selectedClass;

        return null;
    };

    $scope.getTalentByColIndex = function (index, talents) {
        var talent = _.find(talents, { 'colIndex': index });
        return talent ? talent : null;
    };

    $scope.showTalentTooltip = function (event, specIndex, rowIndex, colIndex) {
        $scope.isLoadingTooltip = true;
        var spec = $scope.selectedClass.specifications[specIndex];
        var talent = $scope.getTalentByColIndex(colIndex, spec.talentRows[rowIndex]);

        $scope.inspectedTalent = inspectedTalentVm.build(talent, $scope.selectedTalents[specIndex], $scope.totalPointsPerSpec[specIndex]);

        $timeout(function () {
            var tooltipHeight = angular.element('#talent-tooltip').height();
            var iconPos = angular.element(event.target).offset();
            var topOfPage = angular.element(document).scrollTop();

            var calcTop = iconPos.top - tooltipHeight - 15;
            calcTop = topOfPage > calcTop ? topOfPage + 5 : calcTop;

            $scope.talentTooltipPos.top = calcTop + "px";
            $scope.talentTooltipPos.left = (iconPos.left + 50) + "px";
            $scope.isInspectingTalent = true;
            $scope.isLoadingTooltip = false;
        }, 30);
    };

    $scope.hideTalentTooltip = function () {
        $scope.isInspectingTalent = false;
    };

    $scope.addTalentPoint = function (event, specIndex, rowIndex, colIndex) {
        if (!$scope.isLoadingTooltip && $scope.inspectedTalent
            && $scope.inspectedTalent.isLearnable && !$scope.inspectedTalent.isMaxRank) {

            var spec = $scope.selectedClass.specifications[specIndex];
            var talent = $scope.getTalentByColIndex(colIndex, spec.talentRows[rowIndex]);

            talent.selectedRankNo += 1;

            if (talent.selectedRankNo === 1) {
                $scope.selectedTalents[specIndex].push(talent);
            }

            // Check for newly met talent requirement
            angular.forEach(spec.talentsWithRequirements, function (t) {
                var requirement = _.find(rowAllocationArray, { 'rowIndex': t.rowIndex });

                if (t.talentRequirement.requiredTalentId === talent.id
                    && talent.selectedRankNo === talent.talentRanks.length
                    && $scope.totalPointsPerSpec[specIndex] >= requirement.requiredNo) {

                    var unlockedTalent = $scope.getTalentByColIndex(t.columnIndex, spec.talentRows[t.rowIndex]);
                    toggleActiveTalent(unlockedTalent, true);
                }
            });

            // Update the talent tree and unlock any new rows
            var checkForTierUnlockCallback = function (treeTotal, req, talentRows) {

                if (treeTotal < req.requiredNo && treeTotal + 1 === req.requiredNo) {
                    var rowTalents = talentRows[req.rowIndex];

                    angular.forEach(rowTalents, function (t) {
                        var isActive = true;

                        if (t.talentRequirement !== null) {
                            var requiredTalent = _.find($scope.selectedTalents[t.specIndex], { 'id': t.talentRequirement.requiredTalentId });
                            isActive = requiredTalent && requiredTalent.selectedRankNo === requiredTalent.talentRanks.length;
                        }

                        toggleActiveTalent(t, isActive);
                    });
                }
            };

            updateTalentTree(specIndex, checkForTierUnlockCallback);

            $scope.inspectedTalent.updateRankNo(talent, $scope.selectedTalents[specIndex], $scope.totalPointsPerSpec[specIndex]);
            $scope.totalPointsPerSpec[specIndex] += 1;
            $scope.availablePoints -= 1;
            $scope.requiredLevel += 1;
        }
    };

    $scope.removeTalentPoint = function (event, specIndex, rowIndex, colIndex) {

        if (!$scope.isLoadingTooltip && $scope.inspectedTalent && $scope.inspectedTalent.isUnlearnable) {
            var spec = $scope.selectedClass.specifications[specIndex];
            var talent = $scope.getTalentByColIndex(colIndex, spec.talentRows[rowIndex]);

            talent.selectedRankNo -= 1;

            if (talent.selectedRankNo === 0) {
                removeSelectedTalent(talent, specIndex);
            }

            // Check if talent requirements no longer met
            angular.forEach(spec.talentsWithRequirements, function (t) {
                if (t.talentRequirement.requiredTalentId === talent.id && talent.selectedRankNo !== talent.talentRanks.length) {
                    var lockedTalent = $scope.getTalentByColIndex(t.columnIndex, spec.talentRows[t.rowIndex]);
                    toggleActiveTalent(lockedTalent, false);
                }
            });

            // Update tree and de-activate rows where required points no longer met
            var checkForTierRemovalCallback = function (treeTotal, req, talentRows) {

                if (treeTotal === req.requiredNo && treeTotal - 1 < req.requiredNo) {
                    angular.forEach(talentRows[req.rowIndex], function (t) {
                        toggleActiveTalent(t, false);
                    });
                }
            };

            updateTalentTree(specIndex, checkForTierRemovalCallback);

            $scope.inspectedTalent.updateRankNo(talent, $scope.selectedTalents[specIndex], $scope.totalPointsPerSpec[specIndex]);
            $scope.totalPointsPerSpec[specIndex] -= 1;
            $scope.availablePoints += 1;
            $scope.requiredLevel -= 1;
        }
    };

    $scope.resetSpecificationTree = function (specIndex) {
        var pointsInSpec = $scope.totalPointsPerSpec[specIndex];

        var resetCallback = function (treeTotal, req, talentRows) {
            angular.forEach(talentRows[req.rowIndex], function (t) {
                var remainActive = t.rowIndex === 0 && t.talentRequirement === null;
                toggleActiveTalent(t, remainActive, true);
            });
        };

        updateTalentTree(specIndex, resetCallback);

        $scope.availablePoints += pointsInSpec;
        $scope.requiredLevel -= pointsInSpec;
        $scope.totalPointsPerSpec[specIndex] = 0;
        $scope.selectedTalents[specIndex] = [];
    };

    $scope.resetAllTalents = function () {
        var resetCallback = function (treeTotal, req, talentRows) {
            angular.forEach(talentRows[req.rowIndex], function (t) {
                var remainActive = t.rowIndex === 0 && t.talentRequirement === null;
                toggleActiveTalent(t, remainActive, true);
            });
        };

        for (var i = 0; i < 3; i++) {
            updateTalentTree(i, resetCallback);
        }

        resetTotalPoints();
    };

    function resetTotalPoints() {
        $scope.availablePoints = 51;
        $scope.requiredLevel = 9;
        $scope.totalPointsPerSpec = [0, 0, 0];
        $scope.selectedTalents = [[], [], []];
    }

    function updateTalentTree(specIndex, callback) {
        var treeTotal = $scope.totalPointsPerSpec[specIndex];
        var talentRows = $scope.selectedClass.specifications[specIndex].talentRows;

        angular.forEach(rowAllocationArray, function (req) {
            callback(treeTotal, req, talentRows);
        });
    }

    function toggleActiveTalent(talent, isActive, removePoints) {
        talent.isActive = isActive;
        talent.selectedRankNo = removePoints ? 0 : talent.selectedRankNo;
    }

    function removeSelectedTalent(talent, specIndex) {
        $scope.selectedTalents[specIndex] = $scope.selectedTalents[specIndex].filter(function (t) { return t.id !== talent.id });
    }

    $scope.fetchClasses();
});
