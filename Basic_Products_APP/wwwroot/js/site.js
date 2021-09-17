// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    console.log("document ready");
    $(document).on("click",
        ".edit-product-button",
        function() {
            console.log("clicked " + $(this).val()); 
            var productID = $(this).val();

            $.ajax({
                type: 'json',
                data: {
                    "id": productID
                },
                url: '/product/ShowDetailsJson',
                success: function(data) {
                    console.log(data);
                    $("#modal-input-id").val(data.id);
                    $("#modal-input-name").val(data.name);
                    $("#modal-input-price").val(data.price); 
                    $("#modal-input-description").val(data.description);
                }
            })
        });
    $("#save-botton").click(function() {
        var Product = {
            "Id": $("#modal-input-id").val(),
            "Name": $("#modal-input-name").val(),
            "Price": $("#modal-input-price").val(),
            "Description": $("#modal-input-description").val()
           
        };
        console.log("saved");
        console.log(Product);

        $.ajax({
            type: 'json',
            data: Product,
            url: 'product/ProcessEditReturnPartial',
            success: function(data) {
                console.log(data);
                $("#card-number-" + Product.Id).html(data).hide().fadeIn(2000);
            }
        })
    })
    $(document).on("click", ".details-product-button", function () {
        console.log("clicked " + $(this).val());
        var productID = $(this).val();
        $.ajax({
            type: 'json',
            data: {
                "id": productID
            },
            url: '/product/ShowDetailsJson',
            success: function (data) {
                console.log(data);
                $("#IdArea").html(data.id);
                $("#NameArea").html(data.name);
                $("#PriceArea").html(data.price);
                $("#DescriptionArea").html(data.description);
            }
        })
    })
});