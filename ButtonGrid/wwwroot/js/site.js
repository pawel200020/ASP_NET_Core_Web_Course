// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function() {
    console.log("page is ready");
    $(document).on("click", ".game-button", function (event) {
        event.preventDefault();
        var number = $(this).val();
        console.log(number);
        doBottonUpdate(number);
    })

    function doBottonUpdate (number) {
        $.ajax({
            datatype: "json",
            method: 'POST',
            url: '/Button/showOneButton',
            data: {
                "ButtonNumber": number
            },
            success: function (data) {
                console.log(data);
                $("#" + number).html(data);
            }
    })
    }
})

