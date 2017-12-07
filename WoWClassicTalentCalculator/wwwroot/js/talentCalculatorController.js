﻿
app.controller('talentCalculatorController', function ($scope, $timeout, talentCalculatorFactory, warcraftClassVm, talentReqVm, inspectedTalentVm)
{
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

    $scope.fetchClasses = function () {
        talentCalculatorFactory.getClasses()
            .then(function (response) {
                $scope.classes = response.data.map(warcraftClassVm.build);
                $scope.fetchSpecifications('Shaman');

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

                $scope.selectedClass = warcraftClassVm.build(response.data);
                $scope.getClassById($scope.selectedClass.id).isSelected = true;
                $scope.selectedClassId = $scope.selectedClass.id;

                setTotalPoints();

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
        var spec = $scope.selectedClass.specifications[specIndex];
        var talent = $scope.getTalentByColIndex(colIndex, spec.talentRows[rowIndex]);

        $scope.inspectedTalent = inspectedTalentVm.build(talent, $scope.selectedTalents[specIndex]);

        $timeout(function () {
            var tooltipHeight = angular.element('#talent-tooltip').height();
            var iconPos = angular.element(event.target).offset();
            var topOfPage = angular.element(document).scrollTop();

            var calcTop = iconPos.top - tooltipHeight - 15;
            calcTop = topOfPage > calcTop ? topOfPage + 5 : calcTop;

            $scope.talentTooltipPos.top = calcTop + "px";
            $scope.talentTooltipPos.left = (iconPos.left + 50) + "px";
            $scope.isInspectingTalent = true;
        }, 30);
    };

    $scope.hideTalentTooltip = function () {
        $scope.isInspectingTalent = false;
    };

    $scope.addTalentPoint = function (event, specIndex, rowIndex, colIndex) {
        if ($scope.inspectedTalent && $scope.inspectedTalent.isLearnable && !$scope.inspectedTalent.isMaxRank) {
            var spec = $scope.selectedClass.specifications[specIndex];
            var talent = $scope.getTalentByColIndex(colIndex, spec.talentRows[rowIndex]);

            talent.selectedRankNo += 1;
            $scope.selectedTalents[specIndex].push(talent);
            inspectedTalentVm.updateRankNo($scope.inspectedTalent, talent, $scope.selectedTalents[specIndex]);

            updateTalentTree(specIndex);
            $scope.totalPointsPerSpec[specIndex] += 1;
            $scope.availablePoints -= 1;
            $scope.requiredLevel += 1;
        }
    };

    $scope.removeTalentPoint = function (event, specIndex, rowIndex, colIndex) {
        if ($scope.inspectedTalent && $scope.inspectedTalent.isUnlearnable) {
            var spec = $scope.selectedClass.specifications[specIndex];
            var talent = $scope.getTalentByColIndex(colIndex, spec.talentRows[rowIndex]);

            talent.selectedRankNo -= 1;
            inspectedTalentVm.updateRankNo($scope.inspectedTalent, talent, $scope.selectedTalents[specIndex]);

            $scope.selectedTalents[specIndex] = $scope.selectedTalents[specIndex].filter(function (t) {
                return t.id === talent.id;
            });

            $scope.totalPointsPerSpec[specIndex] -= 1;
            $scope.availablePoints += 1;
            $scope.requiredLevel -= 1;
        }
    };

    function setTotalPoints() {
        $scope.availablePoints = 51;
        $scope.requiredLevel = 9;
        $scope.totalPointsPerSpec = [0, 0, 0];
        $scope.selectedTalents = [[], [], []];
    }

    function updateTalentTree(specIndex) {
        var treeTotal = $scope.totalPointsPerSpec[specIndex];
        var talentRows = $scope.selectedClass.specifications[specIndex].talentRows;

        angular.forEach(talentReqVm.reqArray, function (req) {
            if (treeTotal < req.requiredNo && treeTotal + 1 === req.requiredNo) {
                toggleActiveRow(talentRows[req.rowIndex], true);
            }
        });
    }

    function toggleActiveRow(row, isActive) {
        angular.forEach(row, function (talent) {
            talent.isActive = isActive;
        });
    }

    $scope.fetchClasses();
});
