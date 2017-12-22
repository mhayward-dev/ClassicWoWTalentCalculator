
app.directive('talentIcon', function ($parse, $compile) {

    function createArrowForDirection(direction, t) {
        var req = t.talentRequirement;
        var arrowEl = angular.element('<div class="requirement-arrow">');
        var bgColour = t.isActive ? '#bba911' : '#444';

        if (direction === 'Down') {
            var colsBetweenCount = (t.rowIndex - req.endRowIndex) - 1;
            var pixelDistance = 34 + (colsBetweenCount * 62);
            var lineHeight = pixelDistance - 18;

            arrowEl.width(10);
            arrowEl.height(lineHeight);
            arrowEl.css('bottom', pixelDistance + 'px');
            arrowEl.css('left', '16px');
            arrowEl.css('background-color', bgColour);

            var arrowPointEl = angular.element('<div class="arrow-down">');
            arrowPointEl.css('top', lineHeight - 5);
            arrowPointEl.css('border-top-color', bgColour);
            arrowEl.append(arrowPointEl);
        }

        if (direction === 'Right') {
            console.log('TODO - Right arrow');

        }

        if (direction === 'DownRight') {
            console.log('TODO - DownRight arrow');
        }

        return arrowEl;
    }

    return {
        restrict: 'E',
        link: function (scope, element, attrs) {
            if (attrs.talent.length > 0) {
                attrs.$observe('talent', function (talentJson) {
                    var t = $parse(talentJson)();
                    var iconContainerEl = angular.element('<div class="talent-icon-border inactive">');
                    iconContainerEl.attr('data-talent-Id', t.id);

                    var iconEl = angular.element('<div class="talent-icon">');
                    iconEl.css('background', sprintf('url("%s") no-repeat center center', t.iconFilePath));
                    iconEl.attr('ng-mouseenter', sprintf('showTalentTooltip($event, %s, %s, %s)', t.specIndex, t.rowIndex, t.colIndex));
                    iconEl.attr('ng-mouseleave', 'hideTalentTooltip()');
                    iconEl.attr('ng-click', sprintf('addTalentPoint($event, %s, %s, %s)', t.specIndex, t.rowIndex, t.colIndex));
                    iconEl.attr('ng-right-click', sprintf('removeTalentPoint($event, %s, %s, %s)', t.specIndex, t.rowIndex, t.colIndex));
                    iconContainerEl.append(iconEl);

                    var rankNoEl = angular.element(sprintf('<div class="talent-rank-no">%s</div>', t.selectedRankNo));
                    iconContainerEl.append(rankNoEl);

                    if (t.isActive) {
                        rankNoEl.css('visibility', 'visible');
                        iconContainerEl.removeClass('inactive');
                    }

                    if (t.selectedRankNo == t.talentRanks.length) {
                        rankNoEl.addClass('is-maxed');
                        iconContainerEl.addClass('is-maxed');
                    }

                    if (t.talentRequirement !== null) {
                        var direction = _.get(scope.arrowDirections, t.talentRequirement.arrowDirection);
                        iconContainerEl.append(createArrowForDirection(direction, t));
                    }

                    element.empty();
                    element.append($compile(iconContainerEl)(scope));
                }, true);
            }
        }
    };
});

app.directive('ngRightClick', function ($parse) {
    return function (scope, element, attrs) {
        var fn = $parse(attrs.ngRightClick);
        element.bind('contextmenu', function (event) {
            scope.$apply(function () {
                event.preventDefault();
                fn(scope, { $event: event });
            });
        });
    };
});