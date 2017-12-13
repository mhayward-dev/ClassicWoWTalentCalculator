var app = angular.module('talentCalculatorApp', ['ngAnimate', 'ngSanitize']);

app.factory('warcraftClassVm', warcraftClassVm);
app.factory('warcraftClassSpecificationVm', warcraftClassSpecificationVm);
app.factory('talentVm', talentVm);
app.factory('talentRankVm', talentRankVm);
app.factory('talentReqVm', talentReqVm);
app.factory('inspectedTalentVm', inspectedTalentVm);
app.factory('rowAllocationArray', rowAllocationArray);