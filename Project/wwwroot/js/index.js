$(document).ready(function () {
    console.log("Hello World");
    var theForm = $("#TheForm");
    theForm.hide();

    var button = $("#button");
    button.on("click", function () {
        console.log("Buying...");
    })

    var listItems = document.getElementsByClassName("product-prop");
    listItems[0].addEventListener("click", function () {
        console.log("0000000");
    });

    var popup = $("#login-block .popup-form");
    $("#login-block .toggle-item").on("click", function () {
        popup.slideToggle(250);
    });

});