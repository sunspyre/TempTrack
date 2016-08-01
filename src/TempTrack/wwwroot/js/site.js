// site.js

(function () {

    //JQuery can be called with a $ or JQuery
    var ele = $("#username");
    ele.text("Sugarland");

    //var main = $("#main");
    //main.on("mouseenter", function () {
    //    this.style = "background-color:#888;";
    //});

    //main.on("mouseleave", function () {
    //    this.style = "";
    //});

    //var menuitems = $("ul.menu li a");
    //menuitems.on("click", function () {
    //    var me = $(this); //this represents the object that this is related to
    //    alert(me.text());
    //});

    var $sidebarAndWrapper = $("#sidebar,#wrapper");
    var $icon = $("#sidebarToggle i.fa")

    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        } else {
            $icon.removeClass("fa-angle-right");
            $icon.addClass("fa-angle-left");
        }
    });



})();

