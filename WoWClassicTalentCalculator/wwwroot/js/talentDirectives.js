app.directive('specificationTable', function () {

    setupCell = function () {

    };

    return {
        restrict: 'E',
        link: function ($scope, element, attrs) {
            $scope.$watch('selectedClass', function (selectedClass) {
                var tableHtml = $('<table>');
                var spec = selectedClass.specifications[Number(attrs.specIndex)];

                $.each(spec.talentRows, function (rowIndex, rowArray) {
                    var rowHtml = $('<tr>');

                    for (var i = 0; i < 4; i++) {
                        var cellHtml = $('<td>');

                        var talent = $scope.getTalentByColIndex(i, rowArray);
                        if (talent) {
                            var iconHtml = sprintf('<div class="talent-icon"><img src="%s" /></div>', talent.iconPath);
                            cellHtml.append(iconHtml);
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