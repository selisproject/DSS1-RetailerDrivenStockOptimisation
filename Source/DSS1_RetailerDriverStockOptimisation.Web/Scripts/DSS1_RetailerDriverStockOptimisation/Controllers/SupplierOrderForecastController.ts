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
interface Window { scope_SupplierOrderForecast: DSS1_RetailerDriverStockOptimisation.Controllers.ISupplierOrderForecastScope; }
namespace DSS1_RetailerDriverStockOptimisation.Controllers {
const SupplierOrderForecastConditionalFormattings = [
        ];
const SupplierOrderForecastDataValidations = [
        ];
const SupplierOrderForecastCalculatedExpressions = [
        ];

// Datasets Column Info
var OrderProposalList_ColumnInfo = [
new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Item.SKU",
caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "Item.SKU", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 100,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Item.Description",
caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "Item.Description", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 100,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Warehouse.Description",
caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "Warehouse.Description", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 100,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "decimal",
dataTypeIsEnum: false,
name: "Quantity",
caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "Quantity", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "DateTime",
dataTypeIsEnum: false,
name: "RecommendedOrderDate",
caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "RecommendedOrderDate", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: { 'dateFormat': 'DD/MM/YYYY', 'backEndFormatting': 'dd/MM/yyyy' , 'excelFormat': 'dd/MM/yyyy' },
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "DateTime",
dataTypeIsEnum: false,
name: "SalesForecastDate",
caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "SalesForecastDate", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: { 'dateFormat': 'DD/MM/YYYY', 'backEndFormatting': 'dd/MM/yyyy' , 'excelFormat': 'dd/MM/yyyy' },
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "bool",
dataTypeIsEnum: false,
name: "SupplierCanDeliver",
caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "SupplierCanDeliver", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: true,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.CHECKBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "decimal",
dataTypeIsEnum: false,
name: "SupplierMaxQuantity",
caption: window._resourcesManager.getDataListColumnCaption("OrderProposalList", "SupplierMaxQuantity", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: true,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
})] as any;
window["OrderProposalList_ColumnInfo"] = OrderProposalList_ColumnInfo;

// Datasets Projection Shemas
window["OrderProposalList_ProjectionScema"] = {};


export interface ISupplierOrderForecastScope extends Joove.IWebPageScope {
model:
    DSS1_RetailerDriverStockOptimisation.ViewModels.SupplierOrderForecast.SupplierOrderForecastViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class SupplierOrderForecastController {


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_SupplierOrderForecast.model = window.scope_SupplierOrderForecast.dehydrate();
        //window.scope_MasterPage.model = window.scope_SupplierOrderForecast.model;
        DSS1_RetailerDriverStockOptimisation.ViewModels.SupplierOrderForecast.SupplierOrderForecastViewModel._lightCast(window.scope_SupplierOrderForecast.model);
        // Joove.Common.applyScope(window.scope_SupplierOrderForecast);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: ISupplierOrderForecastScope, $timeout: ng.ITimeoutService) {
        window.scope_SupplierOrderForecast = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS1_RetailerDriverStockOptimisation.ViewModels.SupplierOrderForecast.SupplierOrderForecastViewModel._initializeFrom($scope.model, context);
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

    init($scope: ISupplierOrderForecastScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS1_RetailerDriverStockOptimisation.ViewModels.SupplierOrderForecast.SupplierOrderForecastViewModel._initializeFrom(window.viewDTO.Model);

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
Retrieve:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("SupplierOrderForecast", "Retrieve", "GET", [], {}, _modalOptions);
            },
        };
// Events
        $scope.eventCallbacks = {
        };

// Rules
        window._ruleEngine.addDataValidations(SupplierOrderForecastDataValidations);
        window._ruleEngine.addConditionalFormattings(SupplierOrderForecastConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(SupplierOrderForecastCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPage as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("SupplierOrderForecastController", ["$scope", "$timeout", SupplierOrderForecastController] as Array<string>);
}