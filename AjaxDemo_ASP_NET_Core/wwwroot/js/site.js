// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    console.log("loguje");
    $(".customer-radio").change(function () {
        console.log("changed");
        DoCustUpdate();
    });
    function DoCustUpdate() {
        $.ajax({
            type: "GET",
            url: "Customer/ShowOnePerson",
            data: $("form").serialize(),
            success: function (data) {
                console.log(data);
                $("#CustomerInfoArea").html(data);
            }

        });
    }
    $("#SelectCustomer").click(function () {
        event.preventDefault();
        console.log("clicked");
        DoCustUpdate();

    });
});