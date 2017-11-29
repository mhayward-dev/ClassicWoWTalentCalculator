app.directive('specificationTalents', function () {
    return {
        restrict: 'E',
        link: function (scope, element, attrs) {
            var html = '<table>';

            angular.forEach(scope[attrs.talents], function (tr, index) {
                html += '<td><td>' + tr.talentName + '</td></tr>';
            })

            html += '</table>';
            element.replaceWith(html)

            //angular.forEach(scope[attrs.rows], function (row, index) {
            //    html += '<tr><td>' + row.name + '</td></tr>';
            //    if ('subrows' in row) {
            //        angular.forEach(row.subrows, function (subrow, index) {
            //            html += '<tr><td>' + subrow.name + '</td></tr>';
            //        });
            //    }
            //});
            //html += '</table>';
            //element.replaceWith(html)
        }
    };
});