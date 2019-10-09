//////////////////////////////////////////////////////////////////////////////////////////////
//  Use this javascript file to add custom functionality to your form.                      //
//  Please read the zAppDev JS Developer Api documentation for more info and code samples.  //
//  Documentation can be found at: http://community.zappdev.com/Content/ApiReference.html   //
//////////////////////////////////////////////////////////////////////////////////////////////

$onFormLoaded = function() {
    console.log("Form Loaded! Model object:", $form.model);
    
    $$$("NotificationsShow").click(function() {
        $$$("NotificationsLayout").removeClass("notificationHide").addClass("notificationShow");
    });
    $$$("NotificationsRemove").click(function() {
        $$$("NotificationsLayout").removeClass("notificationShow").addClass("notificationHide");
    });
    
    
    setInterval(function() {
        $form.updateTotalNotifications();
    }, 2000);
    
}
    
$formExtend = function() {
    $form.updateTotalNotifications = function() {
        var number = Joove.Common.getDirectiveScope($$$("NotificationTable")).$totalRows;
        if(number > 0) {
            $$$("TotalNotifications").removeClass("itemsCountHide");
        }else {
            $$$("TotalNotifications").addClass("itemsCountHide");
        }
        $$$("TotalNotifications").text(number);    
    }
    
    console.log("Form extension code executed!");
}