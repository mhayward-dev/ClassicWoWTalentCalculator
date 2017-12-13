
app.directive('talentIcon', function ($parse, $compile) {
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

                    // Only do this once...
                    if (t.talentRequirement !== null) {
                        var req = t.talentRequirement;
                        var arrowEl = angular.element('<div class="requirement-arrow">');
                        var isDownwards = req.endColIndex === t.colIndex;

                        if (isDownwards) {
                            var colsBetweenCount = (t.rowIndex - req.endRowIndex) - 1;
                            var pixelDistance = 34 + (colsBetweenCount * 62);
                            var lineHeight = pixelDistance - 18;
                            // 17px padding between the icon and the cell (multiply by 2)
                            // 62px total height of a full cell

                            arrowEl.width(10);
                            arrowEl.height(lineHeight);
                            arrowEl.css('bottom', pixelDistance + 'px');
                            arrowEl.css('left', '16px');

                            var arrowPointEl = angular.element('<div class="arrow-down">');
                            arrowPointEl.css('top', lineHeight - 10);
                            arrowEl.append(arrowPointEl);

                        } else {
                            // Do Right-Down
                        }

                        iconContainerEl.append(arrowEl);
                    }

                    element.empty();
                    element.append($compile(iconContainerEl)(scope));
                }, true);

                scope.talentsLoadedCount += 1;
            }
        }
    };
});

app.directive('specifications', function ($timeout) {

    function createTalentRequirementArrows(reqs, el) {
        var elementsExist = false;

        angular.forEach(reqs, function (r) {
            var startEl = el.find(sprintf('[data-talent-id="%s"]', r.requiredTalentId));
            var endEl = el.find(sprintf('[data-talent-id="%s"]', r.talentId));

            if (startEl.length > 0 && endEl.length > 0) {
                reqIcons.push({ id: r.requiredTalentId, startRect: startEl.getClientBoundingRect(), endRect: endEl.getClientBoundingRect() });
                elementsExist = true;
            } else {
                elementsExist = false;
                return;
            }
        });

        if (elementsExist) {
            console.log('They exist, plot arrows');
        } else {
            //$timeout(createTalentRequirementArrows(reqs, el), 10000);
        }
    }

    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            scope.$watch('isLoadingTalents()', function (isLoading) {
                if (!isLoading) {
                    //createTalentRequirementArrows(reqs, element);
                    console.log('No longer loading');
                }
            });
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