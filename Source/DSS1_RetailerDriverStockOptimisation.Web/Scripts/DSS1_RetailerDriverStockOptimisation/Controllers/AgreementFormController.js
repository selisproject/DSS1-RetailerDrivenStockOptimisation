var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = y[op[0] & 2 ? "return" : op[0] ? "throw" : "next"]) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [0, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
window.onbeforeunload = function (e) {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg; // Gecko, Trident, Chrome 34+
        return msg;
    }
};
var DSS1_RetailerDriverStockOptimisation;
(function (DSS1_RetailerDriverStockOptimisation) {
    var Controllers;
    (function (Controllers) {
        var AgreementFormConditionalFormattings = [];
        var AgreementFormDataValidations = [];
        var AgreementFormCalculatedExpressions = [];
        // Manual Data for txtStatus
        window["dataFortxtStatus"] = [{
                _key: "A",
                _text: window._resourcesManager.getComboBoxManualValueDisplay('FullTruckDS', '0', false, null),
                _default: false
            }, {
                _key: "INACTIVE",
                _text: window._resourcesManager.getComboBoxManualValueDisplay('FullTruckDS', '1', false, null),
                _default: false
            }];
        // Datasets Column Info
        Controllers.FullTruckDS_ColumnInfo = [new Joove.ColumnInfo("Value", "string", null, true)];
        window["FullTruckDS_ColumnInfo"] = Controllers.FullTruckDS_ColumnInfo;
        // Datasets Projection Shemas
        window["FileAttachment_ProjectionScema"] = { Agreement: { Id: '',
                AgreementDocument: {}
            }
        };
        var AgreementFormController = /** @class */ (function () {
            function AgreementFormController($scope, $timeout) {
                this.$scope = $scope;
                this.controllerActionFinished = function (resetDirty) {
                    //window.scope_AgreementForm.model = window.scope_AgreementForm.dehydrate();
                    //window.scope_MasterPage.model = window.scope_AgreementForm.model;
                    DSS1_RetailerDriverStockOptimisation.ViewModels.AgreementForm.AgreementFormViewModel._lightCast(window.scope_AgreementForm.model);
                    // Joove.Common.applyScope(window.scope_AgreementForm);
                    if (resetDirty) {
                        window._context.isDirty = false;
                    }
                    window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
                };
                window.scope_AgreementForm = $scope;
                $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
                    Joove.Core.onChange(event.target, newValue, dontMakeDirty);
                };
                $scope.dehydrate = function (context) {
                    if (context === void 0) { context = null; }
                    return DSS1_RetailerDriverStockOptimisation.ViewModels.AgreementForm.AgreementFormViewModel._initializeFrom($scope.model, context);
                };
                $scope._validationsMaster = window.scope_MasterPage._validations;
                $scope._validations = { summary: [],
                };
                this.init($scope, $timeout);
                $timeout(function () {
                    window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, function () {
                        $("body").fadeIn(200);
                    });
                });
            }
            AgreementFormController.prototype.init = function ($scope, $timeout) {
                var _this = this;
                $scope.model = DSS1_RetailerDriverStockOptimisation.ViewModels.AgreementForm.AgreementFormViewModel._initializeFrom(window.viewDTO.Model);
                window.scope_MasterPage.model = $scope.model;
                new Joove.ReferencesReconstructor().reconstructReferences($scope.model);
                $scope.trackObject = function (obj) { return Joove.Common.trackObject(obj); };
                //}
                $.connection['eventsHub'].on('__connectedEvent');
                $.connection['eventsHub'].on('forcePageReload', function () {
                    window.onbeforeunload = null;
                    setTimeout(function () {
                        window.location.reload();
                    }, 3000);
                });
                $.connection.hub.start(function () {
                    Joove.Common.getScope().connectedToSignals();
                    Joove.Common.getMasterScope().connectedToSignals();
                });
                $scope.connectedToSignals = function () {
                };
                // Event Listeners
                $scope.events = {};
                $scope.expressions = {};
                // Dataset Handler
                $scope.datasets = {};
                // Controller actions
                $scope.actions = {
                    AddAgreement: function (_cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            Joove.Common.autocompleteFix();
                            Joove.Core.executeRedirectControllerAction("AgreementForm", "AddAgreement", "GET", [], {}, _modalOptions);
                            return [2 /*return*/];
                        });
                    }); },
                    EditAgreement: function (id, _cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            Joove.Common.autocompleteFix();
                            Joove.Core.executeRedirectControllerAction("AgreementForm", "EditAgreement", "GET", [id], {}, _modalOptions);
                            return [2 /*return*/];
                        });
                    }); },
                    SaveAgreement: function (_cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    Joove.Common.autocompleteFix();
                                    return [4 /*yield*/, window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit)];
                                case 1:
                                    _a.sent();
                                    window._context.isDirty = false;
                                    Joove.Core.executeControllerActionNew({
                                        verb: 'POST', controller: 'AgreementForm', action: 'SaveAgreement',
                                        queryData: [], postData: { 'model': $scope.model },
                                        cb: _cb, modalOptions: _modalOptions, event: _e
                                    });
                                    return [2 /*return*/];
                            }
                        });
                    }); },
                    DeleteAgreement: function (_cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            Joove.Common.autocompleteFix();
                            window._context.isDirty = false;
                            Joove.Core.executeControllerActionNew({
                                verb: 'POST', controller: 'AgreementForm', action: 'DeleteAgreement',
                                queryData: [], postData: { 'model': $scope.model },
                                cb: _cb, modalOptions: _modalOptions, event: _e
                            });
                            return [2 /*return*/];
                        });
                    }); },
                };
                // Events
                $scope.eventCallbacks = {
                    ButtonClicked: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockButtonClicked != null) {
                            $timeout.cancel(_this.timeoutDelayLockButtonClicked);
                        }
                        _this.timeoutDelayLockButtonClicked = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                $scope.actions.SaveAgreement(null, null, e);
                            }, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: true, withRequiredFieldsCheck: true });
                        }, 0);
                    },
                };
                // Rules
                window._ruleEngine.addDataValidations(AgreementFormDataValidations);
                window._ruleEngine.addConditionalFormattings(AgreementFormConditionalFormattings);
                window._ruleEngine.addCalculatedExpressions(AgreementFormCalculatedExpressions);
                window._commander.executeCommands(window.viewDTO.ClientCommands);
                window.viewDTO.ClientCommands = [];
                Joove.Common.setNumberLocalizationSettings();
                Joove.DeveloperApi.init($scope, window.scope_MasterPage);
                window.$formExtend && window.$formExtend();
                window.$onFormLoaded && window.$onFormLoaded();
            };
            return AgreementFormController;
        }());
        angular.module("Application").controller("AgreementFormController", ["$scope", "$timeout", AgreementFormController]);
    })(Controllers = DSS1_RetailerDriverStockOptimisation.Controllers || (DSS1_RetailerDriverStockOptimisation.Controllers = {}));
})(DSS1_RetailerDriverStockOptimisation || (DSS1_RetailerDriverStockOptimisation = {}));