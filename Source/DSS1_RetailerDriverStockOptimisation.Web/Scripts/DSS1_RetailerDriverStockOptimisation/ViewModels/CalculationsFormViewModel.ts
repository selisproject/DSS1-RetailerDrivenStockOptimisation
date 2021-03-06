// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS1_RetailerDriverStockOptimisation.ViewModels.CalculationsForm {
export class CalculationsFormViewModel extends DSS1_RetailerDriverStockOptimisation.ViewModels.MasterPage.MasterPageViewModel {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
AlertsLength:
true,Progress:
                true
            }
        } else {
            this._members["AlertsLength"] = true;
            this._members["Progress"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: CalculationsFormViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): CalculationsFormViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        CalculationsFormViewModel = new CalculationsFormViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateCalculationsFormViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateCalculationsFormViewModel(original: CalculationsFormViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;

        this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);

        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if(original.AlertsLength !== undefined) this.AlertsLength = original.AlertsLength;
        if(original.Progress !== undefined) this.Progress = original.Progress;
        this.ListSelectedItemKeys = original.ListSelectedItemKeys;
        this.listOrderForecastsSelectedItemKeys = original.listOrderForecastsSelectedItemKeys;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = CalculationsFormViewModel._initializeFrom(this, ignoreReadOnlyProperties);
            CalculationsFormViewModel._deleteDropDownInitialValues(reduced);
            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): CalculationsFormViewModel {
        var reduced = CalculationsFormViewModel._initializeFrom(this, ignoreReadOnlyProperties);
        CalculationsFormViewModel._deleteDropDownInitialValues(reduced);
        return reduced;
    }

    public static _deleteDropDownInitialValues(reduced: CalculationsFormViewModel) {
        if (reduced == null) return;


        DSS1_RetailerDriverStockOptimisation.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
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

public AlertsLength:
    any;
public Progress:
    any;
public ListSelectedItemKeys:
    any[];
public listOrderForecastsSelectedItemKeys:
    any[];
}

}
