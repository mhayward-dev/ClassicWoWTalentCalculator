
app.directive('talentIcon', function ($parse, $compile) {
    return {
        restrict: 'E',
        link: function (scope, element, attrs) {
            if (attrs.talent.length > 0) {
                attrs.$observe('talent', function (talent) {
                    var t = $parse(talent)();
                    var iconContainerEl = angular.element('<div class="talent-icon-border inactive">');

                    var iconEl = angular.element('<div class="talent-icon">');
                    iconEl.css('background', sprintf('url("%s") no-repeat center center', t.iconFilePath));
                    iconEl.attr('ng-mouseenter', sprintf('showTalentTooltip($event, %s, %s, %s)', t.specIndex, t.rowIndex, t.colIndex));
                    iconEl.attr('ng-mouseleave', 'hideTalentTooltip()');
                    iconEl.attr('ng-click', sprintf('addTalentPoint($event, %s, %s, %s)', t.specIndex, t.rowIndex, t.colIndex));
                    iconContainerEl.append(iconEl);

                    var rankNoEl = angular.element(sprintf('<div class="talent-rank-no">%s</div>', t.selectedRankNo));
                    iconContainerEl.append(rankNoEl);

                    if (t.isActive) {
                        rankNoEl.show();
                        iconContainerEl.removeClass('inactive');
                    }

                    if (t.selectedRankNo == t.talentRanks.length) {
                        rankNoEl.addClass('is-maxed');
                        iconContainerEl.addClass('is-maxed');
                    }

                    element.empty();
                    element.append($compile(iconContainerEl)(scope));
                }, true);
            }
        }
    }
});