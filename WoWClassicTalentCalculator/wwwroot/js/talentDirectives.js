app.directive('specificationTable', function ($compile) {

    var setupIcon = function (t) {
        var icon = angular.element(sprintf('<div class="talent-icon"><img src="%s" /></div>', t.iconFilePath));
        icon.attr('ng-mouseenter', sprintf('showTalentInfoDialog($event, %s)', t.id));

        return icon;
    };

    return {
        restrict: 'E',
        link: function (scope, element, attrs) {
            scope.$watch('selectedClass', function (selectedClass) {
                var tableHtml = angular.element('<table>');
                var spec = selectedClass.specifications[Number(attrs.specIndex)];

                $.each(spec.talentRows, function (rowIndex, rowArray) {
                    var rowHtml = angular.element('<tr>');

                    for (var i = 0; i < 4; i++) {
                        var cellHtml = angular.element('<td>');
                        var talent = scope.getTalentByColIndex(i, rowArray);

                        if (talent) {
                            var icon = setupIcon(talent);
                            cellHtml.append($compile(icon)(scope));
                        }

                        rowHtml.append(cellHtml);
                    }

                    tableHtml.append(rowHtml);
                });

                element.replaceWith(tableHtml);
            });
        }
    };
});