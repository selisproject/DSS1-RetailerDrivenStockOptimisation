// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
window.onbeforeunload = (e) => {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg;     // Gecko, Trident, Chrome 34+
        return msg;
    }
};
interface Window { scope_HomePage: DSS1_RetailerDriverStockOptimisation.Controllers.IHomePageScope; }
namespace DSS1_RetailerDriverStockOptimisation.Controllers {
const HomePageConditionalFormattings = [
                                       ];
const HomePageDataValidations = [
                                ];
const HomePageCalculatedExpressions = [
                                      ];

// Datasets Column Info

// Datasets Projection Shemas


export interface IHomePageScope extends Joove.IWebPageScope {
model:
    DSS1_RetailerDriverStockOptimisation.ViewModels.HomePage.HomePageViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class HomePageController {


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_HomePage.model = window.scope_HomePage.dehydrate();
        //window.scope_MasterPage.model = window.scope_HomePage.model;
        DSS1_RetailerDriverStockOptimisation.ViewModels.HomePage.HomePageViewModel._lightCast(window.scope_HomePage.model);
        // Joove.Common.applyScope(window.scope_HomePage);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IHomePageScope, $timeout: ng.ITimeoutService) {
        window.scope_HomePage = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS1_RetailerDriverStockOptimisation.ViewModels.HomePage.HomePageViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPage._validations;
        $scope._validations = { summary:
                                [],
                              };

        this.init($scope, $timeout);
        $timeout(() => {

            window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {

                $("body").fadeIn(200);

            });
        });

    }

    init($scope: IHomePageScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS1_RetailerDriverStockOptimisation.ViewModels.HomePage.HomePageViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPage.model = $scope.model;

        new Joove.ReferencesReconstructor().reconstructReferences($scope.model);
        $scope.trackObject = obj => Joove.Common.trackObject(obj);


        //}

        $.connection['eventsHub'].on('__connectedEvent');

        $.connection['eventsHub'].on('forcePageReload', () => {
            window.onbeforeunload = null;
            setTimeout(() => {
                window.location.reload();
            }, 3000);
        });
        $.connection.hub.start(() => {
            Joove.Common.getScope().connectedToSignals();
            Joove.Common.getMasterScope().connectedToSignals();

        });
        $scope.connectedToSignals = () => {
        }
// Event Listeners
        $scope.events = {
        };
        $scope.expressions = {
        }
// Dataset Handler
        $scope.datasets = {
        };
// Controller actions
        $scope.actions = {
Render:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("HomePage", "Render", "GET", [], {}, _modalOptions);
            },
        };
// Events
        $scope.eventCallbacks = {
        };

// Rules
        window._ruleEngine.addDataValidations(HomePageDataValidations);
        window._ruleEngine.addConditionalFormattings(HomePageConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(HomePageCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPage as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("HomePageController", ["$scope", "$timeout", HomePageController] as Array<string>);
}