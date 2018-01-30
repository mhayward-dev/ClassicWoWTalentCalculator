
app.directive('talentIcon', function ($parse, $compile) {

    function createArrowForDirection(t) {
        var rt = t.requiredTalent;
        var arrowEl = angular.element('<div class="requirement-arrow">');
        var bgColour = t.isActive ? '#bba911' : '#7D7D7D';

        if (rt.arrowDirection === 'Down') {
            var rowsBetweenCount = (t.rowIndex - rt.rowIndex) - 1;
            var pixelDistance = 34 + (rowsBetweenCount * 62);
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

        if (rt.arrowDirection === 'Right') {
            var colsBetweenCount = (t.colIndex - rt.colIndex) - 1;
            var pixelDistance = 30 + (colsBetweenCount * 80);

            arrowEl.height(10);
            arrowEl.width(pixelDistance);
            arrowEl.css('right', pixelDistance + 'px');
            arrowEl.css('background-color', bgColour);

            var arrowPointEl = angular.element('<div class="arrow-right">');
            arrowPointEl.css('left', pixelDistance - 6);
            arrowPointEl.css('border-left-color', bgColour);
            arrowEl.append(arrowPointEl);
        }

        if (rt.arrowDirection === 'DownRight') {
            arrowEl = [];

            var rightArrowEl = angular.element('<div class="requirement-arrow">');
            rightArrowEl.height(10);
            rightArrowEl.width(55);
            rightArrowEl.css('right', '32px');
            rightArrowEl.css('bottom', '60px');
            rightArrowEl.css('background-color', bgColour);
            arrowEl.push(rightArrowEl);

            var downwardsArrow = angular.element('<div class="requirement-arrow">');
            downwardsArrow.width(10);
            downwardsArrow.height(42);
            downwardsArrow.css('bottom','70px');
            downwardsArrow.css('left', '16px');
            downwardsArrow.css('box-shadow', 'none');
            downwardsArrow.css('background-color', bgColour);

            var arrowPointEl = angular.element('<div class="arrow-down">');
            arrowPointEl.css('top', '37px');
            arrowPointEl.css('border-top-color', bgColour);
            downwardsArrow.append(arrowPointEl);

            arrowEl.push(downwardsArrow);
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

                    var iconEl = angular.element('<div class="talent-icon inactive">');
                    iconEl.css('background', sprintf('url("%s") no-repeat center center', '../' + t.iconFilePath));
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
                        iconEl.removeClass('inactive');
                    }

                    if (t.selectedRankNo == t.talentRanks.length) {
                        rankNoEl.addClass('is-maxed');
                        iconContainerEl.addClass('is-maxed');
                    }

                    if (t.requiredTalent !== null) {
                        iconContainerEl.append(createArrowForDirection(t));
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