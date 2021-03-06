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
        var SupplierOrderForecast;
        (function (SupplierOrderForecast) {
            var SupplierOrderForecastViewModel = /** @class */ (function (_super) {
                __extends(SupplierOrderForecastViewModel, _super);
                function SupplierOrderForecastViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {};
                    }
                    else {
                    }
                    return _this;
                }
                SupplierOrderForecastViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                SupplierOrderForecastViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new SupplierOrderForecastViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateSupplierOrderForecastViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                SupplierOrderForecastViewModel.prototype._hydrateSupplierOrderForecastViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    this.OrderProposalListSelectedItemKeys = original.OrderProposalListSelectedItemKeys;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = SupplierOrderForecastViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        SupplierOrderForecastViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                SupplierOrderForecastViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = SupplierOrderForecastViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    SupplierOrderForecastViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                SupplierOrderForecastViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    DSS1_RetailerDriverStockOptimisation.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
                };
                SupplierOrderForecastViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return SupplierOrderForecastViewModel;
            }(DSS1_RetailerDriverStockOptimisation.ViewModels.MasterPage.MasterPageViewModel));
            SupplierOrderForecast.SupplierOrderForecastViewModel = SupplierOrderForecastViewModel;
        })(SupplierOrderForecast = ViewModels.SupplierOrderForecast || (ViewModels.SupplierOrderForecast = {}));
    })(ViewModels = DSS1_RetailerDriverStockOptimisation.ViewModels || (DSS1_RetailerDriverStockOptimisation.ViewModels = {}));
})(DSS1_RetailerDriverStockOptimisation || (DSS1_RetailerDriverStockOptimisation = {}));
