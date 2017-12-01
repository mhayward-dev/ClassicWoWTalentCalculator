app.directive('specificationTable', function ($compile) {

    var setupIcon = function (t) {
        var icon = angular.element(sprintf('<div class="talent-icon"><img src="%s" /></div>', t.iconFilePath));
        icon.attr('ng-mouseenter', sprintf('showTalentInfo($event, %s, %s)', t.rowIndex, t.colIndex));
        icon.attr('ng-mouseleave', 'hideTalentInfo()');

        return icon;
    };

    return {
        restrict: 'E',
        link: function (scope, element, attrs) {
            scope.$watch('selectedClass', function (selectedClass) {
                var tableEl = angular.element('<table>');
                var spec = selectedClass.specifications[Number(attrs.specIndex)];

                $.each(spec.talentRows, function (rowIndex, rowArray) {
                    var rowEl = angular.element('<tr>');

                    for (var i = 0; i < 4; i++) {
                        var cellEl = angular.element('<td>');
                        var talent = scope.getTalentByColIndex(i, rowArray);

                        if (talent) {
                            cellEl.append(setupIcon(talent));
                        }

                        rowEl.append(cellEl);
                    }

                    tableEl.append(rowEl);
                });

                $compile(tableEl)(scope);
                element.replaceWith(tableEl);
            });
        }
    };
});