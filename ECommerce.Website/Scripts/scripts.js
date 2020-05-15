
function AddAndRemoveButtonClicks(cart_amount_id, add_url, remove_url, item_id) {
    $("#add").click(function () {
        $.post({
            url: add_url,
            data: { id: item_id },
        });
        ReloadCartAmonut(cart_amount_id);
    });
    $("#remove").click(function () {
        $.post({
            url: remove_url,
            data: { id: item_id },
        });
        ReloadCartAmonut(cart_amount_id);
    });
}

function ReloadCartAmonut(cart_amount_id) {
    $(cart_amount_id).load(location.href + " " + cart_amount_id + ">*", "");
}