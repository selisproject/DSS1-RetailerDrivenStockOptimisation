function custom_SonaeDSS_dirty_fix(requestParameters) {
                    var selectedItems = window["scope_" + window._context.currentController].model.SelectedOrderFDetails;
                    var selectedItem = selectedItems.filter(function (item) { return item._key === requestParameters.key; })[0];
                    if (selectedItem == undefined) {
                        console.log("ERROR: Could not find item with key " + requestParameters.key + " in SelectedOrderFDetails. The updated item will have its value overwriten in the server!");
                    }
                    selectedItem[requestParameters.property] = requestParameters.value;
}