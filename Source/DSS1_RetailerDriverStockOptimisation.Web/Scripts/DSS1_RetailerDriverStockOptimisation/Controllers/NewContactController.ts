// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
$(document).keyup((e) => {
    if (e.which === 13 && Joove.Common.eventPreventsDefaultFormAction(e as JQueryEventObject) === false && !$(e.target).parent().hasClass("search-element")) {
        window._popUpManager.previouslyFocusedElement = document.activeElement;
        $(":focus").blur();
        Joove.Core.getScope().eventCallbacks.SaveBtnClicked(e);
    }
});
window.onbeforeunload = (e) => {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg;     // Gecko, Trident, Chrome 34+
        return msg;
    }
};
interface Window { scope_NewContact: DSS1_RetailerDriverStockOptimisation.Controllers.INewContactScope; }
namespace DSS1_RetailerDriverStockOptimisation.Controllers {
const NewContactConditionalFormattings = [
new Joove.JbRule({
name: "UserIsNewConditional",
type: Joove.RuleTypes.ConditionalFormatting,
isDataSetRule: false,
evaluatedAtServer: false,
contextControlName: null,


condition: async (_parents) => {
        return Joove.Common.nullSafe<any>(() => window._context.currentAction == "NewUser", false);

    },
evaluationTimes: [Joove.EvaluationTimes.OnLoad],
isRelatedToDataValidation: false
}),
        ];
const NewContactDataValidations = [
new Joove.JbRule({
name: "IsMailValidValidation",
type: Joove.RuleTypes.DataValidation,
evaluatedAtServer: false,
isDataSetRule: false,
group: "",



condition: async (_parents) => {
        return !(Joove.Common.nullSafe<any>(() => Joove.Common.isValidEmail(Joove.Common.nullSafe<any>(() => window["scope_NewContact"].model.ApplicationUser.Email, "")), false));


    },
expression: async function(_parents) {
        return Joove.Common.nullSafe<any>(() => window._resourcesManager.getLocalResource("RES_DATAVALIDATION_MESSAGE_IsMailValid", false), "");
    },
dataValidationMessageType:  Joove.DataValidationMessageType.ERROR,
evaluationTimes: [Joove.EvaluationTimes.OnSubmit],
originalName: 'IsMailValid',
fromMasterPage: false
}),
                                  ];
const NewContactCalculatedExpressions = [
                                        ];

// Datasets Column Info
var PickList_ColumnInfo = [
new Joove.Widgets.DataListColumnInfo({
dataType: "int",
dataTypeIsEnum: false,
name: "Id",
caption: window._resourcesManager.getDataListColumnCaption("PickList", "Id", true),
groupable: true,
searchable: true,
visible: false,
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
dataType: "string",
dataTypeIsEnum: false,
name: "Code",
caption: window._resourcesManager.getDataListColumnCaption("PickList", "Code", true),
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
name: "Name",
caption: window._resourcesManager.getDataListColumnCaption("PickList", "Name", true),
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
})] as any;
window["PickList_ColumnInfo"] = PickList_ColumnInfo;
var Button1_ColumnInfo = [
new Joove.Widgets.DataListColumnInfo({
dataType: "int",
dataTypeIsEnum: false,
name: "Id",
caption: window._resourcesManager.getDataListColumnCaption("Button1", "Id", true),
groupable: true,
searchable: false,
visible: false,
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
dataType: "string",
dataTypeIsEnum: false,
name: "Name",
caption: window._resourcesManager.getDataListColumnCaption("Button1", "Name", true),
groupable: true,
searchable: false,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 255,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Description",
caption: window._resourcesManager.getDataListColumnCaption("Button1", "Description", true),
groupable: true,
searchable: false,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 1000,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
})] as any;
window["Button1_ColumnInfo"] = Button1_ColumnInfo;
var Button2_ColumnInfo = [
new Joove.Widgets.DataListColumnInfo({
dataType: "int",
dataTypeIsEnum: false,
name: "Id",
caption: window._resourcesManager.getDataListColumnCaption("Button2", "Id", true),
groupable: true,
searchable: false,
visible: false,
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
dataType: "string",
dataTypeIsEnum: false,
name: "Name",
caption: window._resourcesManager.getDataListColumnCaption("Button2", "Name", true),
groupable: true,
searchable: false,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 255,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Description",
caption: window._resourcesManager.getDataListColumnCaption("Button2", "Description", true),
groupable: true,
searchable: false,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 1000,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
})] as any;
window["Button2_ColumnInfo"] = Button2_ColumnInfo;

// Datasets Projection Shemas
window["PickList_ProjectionScema"] = {};
window["Button1_ProjectionScema"] = {};
window["Button2_ProjectionScema"] = {};


export interface INewContactScope extends Joove.IWebPageScope {
model:
    DSS1_RetailerDriverStockOptimisation.ViewModels.NewContact.NewContactViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,
IsMailValid: Joove.Validation.BindingEntry,UserName: Joove.Validation.BindingEntry,Email: Joove.Validation.BindingEntry,
    },
    _masterValidations?: any;
}

class NewContactController {
private timeoutDelayLockButton1OnChange:
    any;
private timeoutDelayLockButton2OnChange:
    any;
private timeoutDelayLockSaveBtnClicked:
    any;
private timeoutDelayLockExitBtnClicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_NewContact.model = window.scope_NewContact.dehydrate();
        //window.scope_MasterPageForSlide.model = window.scope_NewContact.model;
        DSS1_RetailerDriverStockOptimisation.ViewModels.NewContact.NewContactViewModel._lightCast(window.scope_NewContact.model);
        // Joove.Common.applyScope(window.scope_NewContact);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: INewContactScope, $timeout: ng.ITimeoutService) {
        window.scope_NewContact = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS1_RetailerDriverStockOptimisation.ViewModels.NewContact.NewContactViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPageForSlide._validations;
        $scope._validations = { summary:
                                [],
                                IsMailValid:
                                { rule: NewContactDataValidations[0], group: NewContactDataValidations[0].group },
                                UserName:
                                { requiredControlId: 'UserName', group: null },
                                Email:
                                { requiredControlId: 'Email', group: null },
                              };

        this.init($scope, $timeout);
        $timeout(() => {

            window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {

                $("body").fadeIn(200);

            });
        });

    }

    init($scope: INewContactScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS1_RetailerDriverStockOptimisation.ViewModels.NewContact.NewContactViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPageForSlide.model = $scope.model;

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
NewUser:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("NewContact", "NewUser", "GET", [], {}, _modalOptions);
            },
EditUser:
            async (Id, _cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("NewContact", "EditUser", "GET", [Id], {}, _modalOptions);
            },
SaveUser:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'NewContact', action: 'SaveUser',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
DeleteUser:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'NewContact', action: 'DeleteUser',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
Button1Changed:
            async (DataItems, byUser, _cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                const implementation = async (): Promise<any> => {

                    // Joove.Common.applyScope(window.scope_NewContact);
                }


                let spamHelper = new Joove.SpamControlHelper(_e);
                spamHelper.Disable();
                await implementation();
                spamHelper.Enable();
                this.controllerActionFinished(true);
            },
Button2Changed:
            async (DataItems, byUser, _cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                const implementation = async (): Promise<any> => {

                    // Joove.Common.applyScope(window.scope_NewContact);
                }


                let spamHelper = new Joove.SpamControlHelper(_e);
                spamHelper.Disable();
                await implementation();
                spamHelper.Enable();
                this.controllerActionFinished(true);
            },
        };
// Events
        $scope.eventCallbacks = {
Button1OnChange:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);


                if (this.timeoutDelayLockButton1OnChange != null) {
                    $timeout.cancel(this.timeoutDelayLockButton1OnChange);
                }

                this.timeoutDelayLockButton1OnChange = $timeout(() => {

                    if (e.target) {
                        Joove.Core.onChange(e.target, null, false);
                    } else {
                        Joove.Core.onChange($(`[jb-id='${e}']`).get(0), null, false);
                    }


                    Joove.Validation.Manager.validateFormAndExecute(() => {

                        var p_FormControls_NewContact_FormControlsDefinition_Button1_PickListControl_SelectedItems_ApplicationPermissionViewModel = Joove.Common.nullSafe<any>(() => Joove.DatasourceManager.getSelectedItems($("[jb-id='Button1']"), e), null);
                        if( eval(`DSS1_RetailerDriverStockOptimisation.ViewModels.NewContact.FormControls_NewContact_FormControlsDefinition_Button1_PickListControl_SelectedItems_ApplicationPermissionViewModel`) != null && eval(`DSS1_RetailerDriverStockOptimisation.ViewModels.NewContact.FormControls_NewContact_FormControlsDefinition_Button1_PickListControl_SelectedItems_ApplicationPermissionViewModel._initializeFrom`) != null ) {
                            var _initial = p_FormControls_NewContact_FormControlsDefinition_Button1_PickListControl_SelectedItems_ApplicationPermissionViewModel;
                            p_FormControls_NewContact_FormControlsDefinition_Button1_PickListControl_SelectedItems_ApplicationPermissionViewModel = [];
                            for(var _i = 0; _i < _initial.length; _i++) {
                                var _temp = eval(`DSS1_RetailerDriverStockOptimisation.ViewModels.NewContact.FormControls_NewContact_FormControlsDefinition_Button1_PickListControl_SelectedItems_ApplicationPermissionViewModel._initializeFrom(_initial[_i])`);
                                p_FormControls_NewContact_FormControlsDefinition_Button1_PickListControl_SelectedItems_ApplicationPermissionViewModel.push(_temp);

                            }
                        }
                        $scope.actions.Button1Changed(p_FormControls_NewContact_FormControlsDefinition_Button1_PickListControl_SelectedItems_ApplicationPermissionViewModel, true, null, null, e);
                    }, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

Button2OnChange:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);


                if (this.timeoutDelayLockButton2OnChange != null) {
                    $timeout.cancel(this.timeoutDelayLockButton2OnChange);
                }

                this.timeoutDelayLockButton2OnChange = $timeout(() => {

                    if (e.target) {
                        Joove.Core.onChange(e.target, null, false);
                    } else {
                        Joove.Core.onChange($(`[jb-id='${e}']`).get(0), null, false);
                    }


                    Joove.Validation.Manager.validateFormAndExecute(() => {

                        var p_FormControls_NewContact_FormControlsDefinition_Button2_PickListControl_SelectedItems_ApplicationRoleViewModel = Joove.Common.nullSafe<any>(() => Joove.DatasourceManager.getSelectedItems($("[jb-id='Button2']"), e), null);
                        if( eval(`DSS1_RetailerDriverStockOptimisation.ViewModels.NewContact.FormControls_NewContact_FormControlsDefinition_Button2_PickListControl_SelectedItems_ApplicationRoleViewModel`) != null && eval(`DSS1_RetailerDriverStockOptimisation.ViewModels.NewContact.FormControls_NewContact_FormControlsDefinition_Button2_PickListControl_SelectedItems_ApplicationRoleViewModel._initializeFrom`) != null ) {
                            var _initial = p_FormControls_NewContact_FormControlsDefinition_Button2_PickListControl_SelectedItems_ApplicationRoleViewModel;
                            p_FormControls_NewContact_FormControlsDefinition_Button2_PickListControl_SelectedItems_ApplicationRoleViewModel = [];
                            for(var _i = 0; _i < _initial.length; _i++) {
                                var _temp = eval(`DSS1_RetailerDriverStockOptimisation.ViewModels.NewContact.FormControls_NewContact_FormControlsDefinition_Button2_PickListControl_SelectedItems_ApplicationRoleViewModel._initializeFrom(_initial[_i])`);
                                p_FormControls_NewContact_FormControlsDefinition_Button2_PickListControl_SelectedItems_ApplicationRoleViewModel.push(_temp);

                            }
                        }
                        $scope.actions.Button2Changed(p_FormControls_NewContact_FormControlsDefinition_Button2_PickListControl_SelectedItems_ApplicationRoleViewModel, true, null, null, e);
                    }, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

SaveBtnClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockSaveBtnClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockSaveBtnClicked);
                }

                this.timeoutDelayLockSaveBtnClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);
                    window._popUpManager.question(window._resourcesManager.getGlobalResource("RES_WEBFORM_GenericConfirmationQuestion"),
                    window._resourcesManager.getEventConfirmation("SaveBtn", false), (isConfirm) => {
                        if (!isConfirm) return;

                        setTimeout(() => {

                            Joove.Validation.Manager.validateFormAndExecute(() => {
                                $scope.actions.SaveUser(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 1000);
                    });
                }, 0);
            },

ExitBtnClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                Joove.Common.setControlKeyPressed(e, 0);
                window._commander.closeForm();
            },

        };

// Rules
        window._ruleEngine.addDataValidations(NewContactDataValidations);
        window._ruleEngine.addConditionalFormattings(NewContactConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(NewContactCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPageForSlide as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("NewContactController", ["$scope", "$timeout", NewContactController] as Array<string>);
}
