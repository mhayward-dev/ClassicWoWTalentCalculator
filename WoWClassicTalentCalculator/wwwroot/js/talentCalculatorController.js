
app.controller('talentCalculatorController', function ($scope, $timeout, talentCalculatorFactory, warcraftClassVm, inspectedTalentVm) {
    $scope.classes = [];
    $scope.selectedClassId = 0;
    $scope.selectedClass = null;
    $scope.selectedTalents = [];
    $scope.isInspectingTalent = false;
    $scope.inspectedTalent = null;
    $scope.talentTooltipPos = {
        top: 0,
        left: 0
    };

    $scope.fetchClasses = function () {
        talentCalculatorFactory.getClasses()
            .then(function (response) {
                $scope.classes = response.data.map(warcraftClassVm.build);
                $scope.fetchSpecifications('Shaman');

            }, function (error) {
                console.log(error);
            });
    }

    $scope.fetchSpecifications = function (className) {
        talentCalculatorFactory.getSpecifications(className)
            .then(function (response) {
                if ($scope.selectedClassId > 0) {
                    $scope.getClassById($scope.selectedClassId).isSelected = false;
                }

                $scope.selectedClass = warcraftClassVm.build(response.data);
                $scope.getClassById($scope.selectedClass.id).isSelected = true;
                $scope.selectedClassId = $scope.selectedClass.id;

            }, function (error) {
                console.log(error);
            });
    }

    $scope.getClassById = function (id) {
        var selectedClass = _.find($scope.classes, { 'id': id });
        if (selectedClass) return selectedClass;

        return null;
    }

    $scope.getTalentByColIndex = function (index, talents) {
        var talent = _.find(talents, { 'colIndex': index });
        return talent ? talent : null;
    }

    $scope.showTalentTooltip = function (event, specIndex, rowIndex, colIndex) {
        var spec = $scope.selectedClass.specifications[specIndex];
        var talent = $scope.getTalentByColIndex(colIndex, spec.talentRows[rowIndex]);

        $scope.inspectedTalent = inspectedTalentVm.build(talent, $scope.selectedTalents);

        $timeout(function () {
            var tooltipHeight = angular.element('#talent-tooltip').height();
            var iconPos = angular.element(event.target).position();
            var iconOffset = angular.element(document).scrollTop();

            var navEl = angular.element('nav');
            var bottomOfNavPos = navEl.position().top + navEl.offset().top + navEl.outerHeight();

            var calcTop = iconPos.top - tooltipHeight - 10 - iconOffset;
            calcTop = calcTop < bottomOfNavPos ? bottomOfNavPos : calcTop;

            $scope.talentTooltipPos.top = calcTop + "px";
            $scope.talentTooltipPos.left = (iconPos.left + 45) + "px";
            $scope.isInspectingTalent = true;
        }, 30);
    }

    $scope.hideTalentTooltip = function () {
        $scope.isInspectingTalent = false;
    }

    $scope.addTalentPoint = function (event, specIndex, rowIndex, colIndex) {
        if ($scope.inspectedTalent && $scope.inspectedTalent.isLearnable && !$scope.inspectedTalent.isMaxRank) {
            var spec = $scope.selectedClass.specifications[specIndex];
            var talent = $scope.getTalentByColIndex(colIndex, spec.talentRows[rowIndex]);

            talent.selectedRankNo += 1;
            inspectedTalentVm.updateRankNo($scope.inspectedTalent, talent);

            var parentEl = angular.element(event.target).parent();
            angular.element(parentEl).find('.talent-rank-no').text(talent.selectedRankNo);
        }
    }

    $scope.fetchClasses();
});
