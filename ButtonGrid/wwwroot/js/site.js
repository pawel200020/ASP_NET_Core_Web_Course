// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function() {
    console.log("page is ready");

    //$(document).on("click", ".game-button", function (event) {
    //    event.preventDefault();
    //    var number = $(this).val();
    //    console.log(number);
    //    doBottonUpdate(number);
    //})

    $(document).on("mousedown", ".game-button", function (event) {
        event.preventDefault();
        switch (event.which) {
            case 1:
                var number = $(this).val();
                console.log(number);
                doBottonUpdate(number, '/Button/showOneButton');
                break;
            case 2:
                alert("middle");
                break;
            case 3:
                var number = $(this).val();
                console.log(number);
                doBottonUpdate(number, '/Button/rightClickShowOneButton');
                break;
            default:
                alert("nothing");
        }
    })
    //disable context menu
    $(document).bind("contextmenu", function (e) {
        e.preventDefault();
        console.log("prevented")
    })
    function doBottonUpdate (number, urlString) {
        $.ajax({
            datatype: "json",
            method: 'POST',
            url: urlString,
            data: {
                "ButtonNumber": number
            },
            //data to teraz plik json 2 częsciwoy
            success: function (data) {
                console.log(data);
                $("#" + number).html(data.part1);
                $("#messageArea").html(data.part2);
            }
    })
    }
})

