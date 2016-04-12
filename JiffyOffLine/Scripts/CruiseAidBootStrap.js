//Reusable functions to Boot Strap the application
function isOnLine() {
    return navigator.onLine;
}

$(document).ready(function () {
    $(window).bind("online",$.event, function(e){
        reportOnlineStatus();
        //saveToServer();
    });

    $(window).bind("offline",$.event, function(e){
        reportOnlineStatus();
    });

    window.applicationCache.onupdateready = function (e) {
       applicationCache.swapCache();
       window.location.reload();
    }
})

function reportOnlineStatus() {
    var status = $("#onlineStatus");

    if (isOnLine()) {
        status.text("Online");
        status.
            removeClass("offline").
            addClass("online");
    }
    else {
        status.text("Offline");
        status.
            removeClass("online").
            addClass("offline");
    }
}

function saveToLocal() {
    var model = getModel(customerIndex);
    model.Name = $("#name").val();
    model.Note = $("#note").val();
    model.IsDirty = true;
    localStorage.setItem(customerIndex,
        JSON.stringify(model));
    logMessage("'" + model.Name + "' saved locally.");
}