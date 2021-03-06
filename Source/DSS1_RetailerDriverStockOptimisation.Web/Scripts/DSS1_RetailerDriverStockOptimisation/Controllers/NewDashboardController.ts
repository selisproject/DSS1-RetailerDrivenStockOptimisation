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
interface Window { scope_NewDashboard: DSS1_RetailerDriverStockOptimisation.Controllers.INewDashboardScope; }
namespace DSS1_RetailerDriverStockOptimisation.Controllers {
const NewDashboardConditionalFormattings = [
        ];
const NewDashboardDataValidations = [
                                    ];
const NewDashboardCalculatedExpressions = [
        ];
// Manual Data for ddlWarehouse
window["dataForddlWarehouse"] = [ {
    _key: 1,
_text: window._resourcesManager.getComboBoxManualValueDisplay('WarehouseDataSet', '0', false , null),
_default: false
}, {
    _key: 2,
_text: window._resourcesManager.getComboBoxManualValueDisplay('WarehouseDataSet', '1', false , null),
_default: false
}, {
    _key: 3,
_text: window._resourcesManager.getComboBoxManualValueDisplay('WarehouseDataSet', '2', false , null),
_default: false
}, {
    _key: 444,
_text: window._resourcesManager.getComboBoxManualValueDisplay('WarehouseDataSet', '3', false , null),
_default: false
}, {
    _key: 4,
_text: window._resourcesManager.getComboBoxManualValueDisplay('WarehouseDataSet', '4', false , null),
_default: false
} ]

// Datasets Column Info
export var BusinessUnitDataSet_ColumnInfo = [new Joove.ColumnInfo("Description", "string", null, false),
           new Joove.ColumnInfo("original", "BusinessUnit", null, false)];
window["BusinessUnitDataSet_ColumnInfo"] = BusinessUnitDataSet_ColumnInfo;
export var CategoryDataSet_ColumnInfo = [new Joove.ColumnInfo("Description", "string", null, false),
           new Joove.ColumnInfo("original", "Category", null, false)];
window["CategoryDataSet_ColumnInfo"] = CategoryDataSet_ColumnInfo;
export var SubCategoryDataSet_ColumnInfo = [new Joove.ColumnInfo("Description", "string", null, false),
           new Joove.ColumnInfo("original", "SubCategory", null, false)];
window["SubCategoryDataSet_ColumnInfo"] = SubCategoryDataSet_ColumnInfo;
export var BaseUnitDataSet_ColumnInfo = [new Joove.ColumnInfo("Description", "string", null, false),
           new Joove.ColumnInfo("original", "BaseUnit", null, false)];
window["BaseUnitDataSet_ColumnInfo"] = BaseUnitDataSet_ColumnInfo;
export var ItemDataSet_ColumnInfo = [new Joove.ColumnInfo("SKU", "string", null, false),
                                     new Joove.ColumnInfo("original", "Item", null, false)];
window["ItemDataSet_ColumnInfo"] = ItemDataSet_ColumnInfo;
export var Suppliers_ColumnInfo = [new Joove.ColumnInfo("Name", "string", null, false),
                                   new Joove.ColumnInfo("original", "Supplier", null, false)];
window["Suppliers_ColumnInfo"] = Suppliers_ColumnInfo;
export var WarehouseDataSet_ColumnInfo = [new Joove.ColumnInfo("Value", "string", null,  true)];
window["WarehouseDataSet_ColumnInfo"] = WarehouseDataSet_ColumnInfo;
export var ForecastVS_ColumnInfo = [new Joove.ColumnInfo("OrderDateFormatted", "string", null, false),
                                    new Joove.ColumnInfo("SupplierStock", "int", null, false),
                                    new Joove.ColumnInfo("TotalUnits", "int", null, false)];
window["ForecastVS_ColumnInfo"] = ForecastVS_ColumnInfo;
export var StockDataSet_ColumnInfo = [new Joove.ColumnInfo("SalesForecastDateFormatted", "string", null, false),
                                      new Joove.ColumnInfo("TotalUnits", "int", null, false)];
window["StockDataSet_ColumnInfo"] = StockDataSet_ColumnInfo;

export class NewDashboardSubCategoryDataSetViewModelDataset extends Joove.IViewModelDataset<any> {


    constructor(model, partialViewControlName: string = null) {
        super(model, partialViewControlName);
        this.limit = 0;
    }

    Filter(inputs: any): (DataItem: any, index: number, items: Array<any>) => boolean {
        var $scope = { model: this.model };

        return (DataItem, index, items) => {
            return true;


        };
    }

    PackInputs($control: JQuery): any {
        return Joove.DatasourceManager.getDatasetControlInputs($control);
    }

    Sort(items: Joove.ViewModelCollection): Joove.ViewModelCollection {
        return items;
    }

    GetSource(parents: number[]): Joove.ViewModelCollection {
        return this.model.Category.SubCategory;
    }


}



// Datasets Projection Shemas
window["ddlBusinessUnit_ProjectionScema"] = {};



window["ddlSKU_ProjectionScema"] = {};
window["ddlSupplier_ProjectionScema"] = {};





export interface INewDashboardScope extends Joove.IWebPageScope {
model:
    DSS1_RetailerDriverStockOptimisation.ViewModels.NewDashboard.NewDashboardViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class NewDashboardController {
private timeoutDelayLockddlBusinessUnitOnChange:
    any;
private timeoutDelayLockddlCategoryOnChange:
    any;
private timeoutDelayLockddlSubcategoryOnChange:
    any;
private timeoutDelayLockButtonClicked:
    any;
private timeoutDelayLockddlWarehouseOnChange:
    any;
private timeoutDelayLockRowControl7Clicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_NewDashboard.model = window.scope_NewDashboard.dehydrate();
        //window.scope_MasterPage.model = window.scope_NewDashboard.model;
        DSS1_RetailerDriverStockOptimisation.ViewModels.NewDashboard.NewDashboardViewModel._lightCast(window.scope_NewDashboard.model);
        // Joove.Common.applyScope(window.scope_NewDashboard);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: INewDashboardScope, $timeout: ng.ITimeoutService) {
        window.scope_NewDashboard = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS1_RetailerDriverStockOptimisation.ViewModels.NewDashboard.NewDashboardViewModel._initializeFrom($scope.model, context);
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

    init($scope: INewDashboardScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS1_RetailerDriverStockOptimisation.ViewModels.NewDashboard.NewDashboardViewModel._initializeFrom(window.viewDTO.Model);

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

SubCategoryDataSet:
            (partialViewControlName: string = null) => {
                return new DSS1_RetailerDriverStockOptimisation.Controllers.NewDashboardSubCategoryDataSetViewModelDataset($scope.model, partialViewControlName);
            },
        };
// Controller actions
        $scope.actions = {
Render:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("NewDashboard", "Render", "GET", [], {}, _modalOptions);
            },
LeadTimeDay:
            async (sku, locID, _cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();
                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'NewDashboard', action: 'LeadTimeDay',
queryData: [], postData: {'model': $scope.model, 'sku': sku, 'locID': locID},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
AssignValues:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();
                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'NewDashboard', action: 'AssignValues',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
AssignSKUinChart:
            async (sku, warehouse, _cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();
                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'NewDashboard', action: 'AssignSKUinChart',
queryData: [], postData: {'model': $scope.model, 'sku': sku, 'warehouse': warehouse},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
afterSelectingSKU:
            async (sku, _cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'NewDashboard', action: 'afterSelectingSKU',
queryData: [], postData: {'model': $scope.model, 'sku': sku},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
refresh:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'NewDashboard', action: 'refresh',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
clearBelowBusinessUnits:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                const implementation = async (): Promise<any> => {
                    window["scope_NewDashboard"].model.SubCategory = null;

                    window["scope_NewDashboard"].model.Category = null;

                    window["scope_NewDashboard"].model.Item = null;

                    window["scope_NewDashboard"].model.BaseUnit = null;


                    // Joove.Common.applyScope(window.scope_NewDashboard);
                }

                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                let spamHelper = new Joove.SpamControlHelper(_e);
                spamHelper.Disable();
                await implementation();
                spamHelper.Enable();
                this.controllerActionFinished(true);
            },
clearBelowCat:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                const implementation = async (): Promise<any> => {
                    window["scope_NewDashboard"].model.SubCategory = null;

                    window["scope_NewDashboard"].model.Item = null;

                    window["scope_NewDashboard"].model.BaseUnit = null;


                    // Joove.Common.applyScope(window.scope_NewDashboard);
                }

                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                let spamHelper = new Joove.SpamControlHelper(_e);
                spamHelper.Disable();
                await implementation();
                spamHelper.Enable();
                this.controllerActionFinished(true);
            },
ClearBelowSubCat:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                const implementation = async (): Promise<any> => {
                    window["scope_NewDashboard"].model.Item = null;

                    window["scope_NewDashboard"].model.BaseUnit = null;


                    // Joove.Common.applyScope(window.scope_NewDashboard);
                }

                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                let spamHelper = new Joove.SpamControlHelper(_e);
                spamHelper.Disable();
                await implementation();
                spamHelper.Enable();
                this.controllerActionFinished(true);
            },
clearItem:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                const implementation = async (): Promise<any> => {
                    window["scope_NewDashboard"].model.Item = null;


                    // Joove.Common.applyScope(window.scope_NewDashboard);
                }

                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                let spamHelper = new Joove.SpamControlHelper(_e);
                spamHelper.Disable();
                await implementation();
                spamHelper.Enable();
                this.controllerActionFinished(true);
            },
        };
// Events
        $scope.eventCallbacks = {
ddlBusinessUnitOnChange:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);


                if (this.timeoutDelayLockddlBusinessUnitOnChange != null) {
                    $timeout.cancel(this.timeoutDelayLockddlBusinessUnitOnChange);
                }

                this.timeoutDelayLockddlBusinessUnitOnChange = $timeout(() => {

                    if (e.target) {
                        Joove.Core.onChange(e.target, null, false);
                    } else {
                        Joove.Core.onChange($(`[jb-id='${e}']`).get(0), null, false);
                    }


                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        $scope.actions.clearBelowBusinessUnits(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: true, withRequiredFieldsCheck: false });
                }, 0);
            },

ddlCategoryOnChange:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);


                if (this.timeoutDelayLockddlCategoryOnChange != null) {
                    $timeout.cancel(this.timeoutDelayLockddlCategoryOnChange);
                }

                this.timeoutDelayLockddlCategoryOnChange = $timeout(() => {

                    if (e.target) {
                        Joove.Core.onChange(e.target, null, false);
                    } else {
                        Joove.Core.onChange($(`[jb-id='${e}']`).get(0), null, false);
                    }


                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        $scope.actions.clearBelowCat(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: true, withRequiredFieldsCheck: false });
                }, 0);
            },

ddlSubcategoryOnChange:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);


                if (this.timeoutDelayLockddlSubcategoryOnChange != null) {
                    $timeout.cancel(this.timeoutDelayLockddlSubcategoryOnChange);
                }

                this.timeoutDelayLockddlSubcategoryOnChange = $timeout(() => {

                    if (e.target) {
                        Joove.Core.onChange(e.target, null, false);
                    } else {
                        Joove.Core.onChange($(`[jb-id='${e}']`).get(0), null, false);
                    }


                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        $scope.actions.ClearBelowSubCat(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: true, withRequiredFieldsCheck: false });
                }, 0);
            },

ButtonClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockButtonClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockButtonClicked);
                }

                this.timeoutDelayLockButtonClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        $scope.actions.refresh(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

ddlWarehouseOnChange:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);


                if (this.timeoutDelayLockddlWarehouseOnChange != null) {
                    $timeout.cancel(this.timeoutDelayLockddlWarehouseOnChange);
                }

                this.timeoutDelayLockddlWarehouseOnChange = $timeout(() => {

                    if (e.target) {
                        Joove.Core.onChange(e.target, null, false);
                    } else {
                        Joove.Core.onChange($(`[jb-id='${e}']`).get(0), null, false);
                    }


                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        $scope.actions.refresh(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

RowControl7Clicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockRowControl7Clicked != null) {
                    $timeout.cancel(this.timeoutDelayLockRowControl7Clicked);
                }

                this.timeoutDelayLockRowControl7Clicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        $scope.actions.AssignSKUinChart(Joove.Common.nullSafe<any>(() => _parents[0].Item.SKU, ""), Joove.Common.nullSafe<any>(() => _parents[0].Warehouse.Id, 0), null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: true, withRequiredFieldsCheck: true });
                }, 0);
            },

        };

// Rules
        window._ruleEngine.addDataValidations(NewDashboardDataValidations);
        window._ruleEngine.addConditionalFormattings(NewDashboardConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(NewDashboardCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPage as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("NewDashboardController", ["$scope", "$timeout", NewDashboardController] as Array<string>);
}
