var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS1_RetailerDriverStockOptimisation;
(function (DSS1_RetailerDriverStockOptimisation) {
    var ViewModels;
    (function (ViewModels) {
        var ThemePreview;
        (function (ThemePreview) {
            var ThemePreviewViewModel = /** @class */ (function (_super) {
                __extends(ThemePreviewViewModel, _super);
                function ThemePreviewViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Ops: true, JustDate: true, JustString: true, AnImageUrl: true, JustAnInt: true, Users: true
                        };
                    }
                    else {
                        _this._members["Ops"] = true;
                        _this._members["JustDate"] = true;
                        _this._members["JustString"] = true;
                        _this._members["AnImageUrl"] = true;
                        _this._members["JustAnInt"] = true;
                        _this._members["Users"] = true;
                    }
                    _this.Ops = new Array();
                    _this.Users = new Array();
                    return _this;
                }
                ThemePreviewViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.Ops != null) {
                        for (var i = 0; i < instance.Ops.length; i++) {
                            instance.Ops[i] = Ops_ApplicationOperationViewModel._lightCast(instance.Ops[i]);
                        }
                    }
                    if (instance.JustDate != null)
                        instance.JustDate = new Date(instance.JustDate);
                    if (instance.Users != null) {
                        for (var i = 0; i < instance.Users.length; i++) {
                            instance.Users[i] = Users_ApplicationUserViewModel._lightCast(instance.Users[i]);
                        }
                    }
                    return instance;
                };
                ThemePreviewViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ThemePreviewViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateThemePreviewViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ThemePreviewViewModel.prototype._hydrateThemePreviewViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original.Ops != null) {
                        for (var i = 0; i < original.Ops.length; i++) {
                            this.Ops.push(Ops_ApplicationOperationViewModel._initializeFrom(original.Ops[i], ignoreReadOnlyProperties, context));
                        }
                    }
                    if (!CLMS.Framework.String.IsNullOrEmpty(original.JustDate))
                        this.JustDate = new Date(original.JustDate);
                    if (original.JustString !== undefined)
                        this.JustString = original.JustString;
                    if (original.AnImageUrl !== undefined)
                        this.AnImageUrl = original.AnImageUrl;
                    if (original.JustAnInt !== undefined)
                        this.JustAnInt = original.JustAnInt;
                    if (original.Users != null) {
                        for (var i = 0; i < original.Users.length; i++) {
                            this.Users.push(Users_ApplicationUserViewModel._initializeFrom(original.Users[i], ignoreReadOnlyProperties, context));
                        }
                    }
                    this.DropdownBoxSelectedItemKeys = original.DropdownBoxSelectedItemKeys;
                    this.DropdownBox1SelectedItemKeys = original.DropdownBox1SelectedItemKeys;
                    this.OptionButtonSelectedItemKeys = original.OptionButtonSelectedItemKeys;
                    this.ChartSelectedItemKeys = original.ChartSelectedItemKeys;
                    this.NewMapSelectedItemKeys = original.NewMapSelectedItemKeys;
                    this.Table2SelectedItemKeys = original.Table2SelectedItemKeys;
                    this.ListSelectedItemKeys = original.ListSelectedItemKeys;
                    this.PickListSelectedItemKeys = original.PickListSelectedItemKeys;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ThemePreviewViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        ThemePreviewViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ThemePreviewViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ThemePreviewViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    ThemePreviewViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                ThemePreviewViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    DSS1_RetailerDriverStockOptimisation.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
                };
                ThemePreviewViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ThemePreviewViewModel;
            }(DSS1_RetailerDriverStockOptimisation.ViewModels.MasterPage.MasterPageViewModel));
            ThemePreview.ThemePreviewViewModel = ThemePreviewViewModel;
            var Ops_ApplicationOperationViewModel = /** @class */ (function (_super) {
                __extends(Ops_ApplicationOperationViewModel, _super);
                function Ops_ApplicationOperationViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Id: true, IsAvailableToAnonymous: true, Name: true, ParentControllerName: true
                        };
                    }
                    else {
                        _this._members["Id"] = true;
                        _this._members["IsAvailableToAnonymous"] = true;
                        _this._members["Name"] = true;
                        _this._members["ParentControllerName"] = true;
                    }
                    return _this;
                }
                Ops_ApplicationOperationViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                Ops_ApplicationOperationViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new Ops_ApplicationOperationViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateOps_ApplicationOperationViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                Ops_ApplicationOperationViewModel.prototype._hydrateOps_ApplicationOperationViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original._versionTimestamp !== undefined)
                        this._versionTimestamp = original._versionTimestamp;
                    if (original.Id !== undefined)
                        this.Id = original.Id;
                    if (original.IsAvailableToAnonymous !== undefined)
                        this.IsAvailableToAnonymous = original.IsAvailableToAnonymous;
                    if (original.Name !== undefined)
                        this.Name = original.Name;
                    if (original.ParentControllerName !== undefined)
                        this.ParentControllerName = original.ParentControllerName;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = Ops_ApplicationOperationViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                Ops_ApplicationOperationViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = Ops_ApplicationOperationViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                Ops_ApplicationOperationViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return Ops_ApplicationOperationViewModel;
            }(BaseClass.ViewModel));
            ThemePreview.Ops_ApplicationOperationViewModel = Ops_ApplicationOperationViewModel;
            var Users_ApplicationUserViewModel = /** @class */ (function (_super) {
                __extends(Users_ApplicationUserViewModel, _super);
                function Users_ApplicationUserViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            UserName: true
                        };
                    }
                    else {
                        _this._members["UserName"] = true;
                    }
                    return _this;
                }
                Users_ApplicationUserViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                Users_ApplicationUserViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new Users_ApplicationUserViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateUsers_ApplicationUserViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                Users_ApplicationUserViewModel.prototype._hydrateUsers_ApplicationUserViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original._versionTimestamp !== undefined)
                        this._versionTimestamp = original._versionTimestamp;
                    if (original.UserName !== undefined)
                        this.UserName = original.UserName;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = Users_ApplicationUserViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                Users_ApplicationUserViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = Users_ApplicationUserViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                Users_ApplicationUserViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return Users_ApplicationUserViewModel;
            }(BaseClass.ViewModel));
            ThemePreview.Users_ApplicationUserViewModel = Users_ApplicationUserViewModel;
        })(ThemePreview = ViewModels.ThemePreview || (ViewModels.ThemePreview = {}));
    })(ViewModels = DSS1_RetailerDriverStockOptimisation.ViewModels || (DSS1_RetailerDriverStockOptimisation.ViewModels = {}));
})(DSS1_RetailerDriverStockOptimisation || (DSS1_RetailerDriverStockOptimisation = {}));