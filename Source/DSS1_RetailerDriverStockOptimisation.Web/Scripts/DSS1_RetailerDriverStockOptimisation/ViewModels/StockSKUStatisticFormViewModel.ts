// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS1_RetailerDriverStockOptimisation.ViewModels.StockSKUStatisticForm {
export class StockSKUStatisticFormViewModel extends DSS1_RetailerDriverStockOptimisation.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
WarehouseId:
true,Description:
                true
            }
        } else {
            this._members["WarehouseId"] = true;
            this._members["Description"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: StockSKUStatisticFormViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): StockSKUStatisticFormViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        StockSKUStatisticFormViewModel = new StockSKUStatisticFormViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateStockSKUStatisticFormViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateStockSKUStatisticFormViewModel(original: StockSKUStatisticFormViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;

        this._hydrateMasterPageForSlideViewModel(original, ignoreReadOnlyProperties, context);

        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if(original.WarehouseId !== undefined) this.WarehouseId = original.WarehouseId;
        if(original.Description !== undefined) this.Description = original.Description;
        this.Chart2SelectedItemKeys = original.Chart2SelectedItemKeys;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = StockSKUStatisticFormViewModel._initializeFrom(this, ignoreReadOnlyProperties);
            StockSKUStatisticFormViewModel._deleteDropDownInitialValues(reduced);
            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): StockSKUStatisticFormViewModel {
        var reduced = StockSKUStatisticFormViewModel._initializeFrom(this, ignoreReadOnlyProperties);
        StockSKUStatisticFormViewModel._deleteDropDownInitialValues(reduced);
        return reduced;
    }

    public static _deleteDropDownInitialValues(reduced: StockSKUStatisticFormViewModel) {
        if (reduced == null) return;


        DSS1_RetailerDriverStockOptimisation.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel._deleteDropDownInitialValues(reduced);
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public WarehouseId:
    any;
public Description:
    any;
public Chart2SelectedItemKeys:
    any[];
}

}