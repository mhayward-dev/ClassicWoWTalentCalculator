app.directive('specificationTable', function () {
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
                            cellHtml.text('X');
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