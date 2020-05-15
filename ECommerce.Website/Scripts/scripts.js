
function AddAndRemoveButtonClicks(add_url, remove_url, item_id) {
    $("#add-"+item_id).click(function () {
        $.post({
            url: add_url,
            data: { id: item_id }
        });
        ReloadDiv("#cart-amount-"+item_id);
    });
    $("#remove-"+item_id).click(function () {
        $.post({
            url: remove_url,
            data: { id: item_id }
        });
        ReloadDiv("#cart-amount-"+item_id);
    });
}

function ReloadDiv(div_id) {
    $(div_id).load(location.href + " " + div_id + ">*", "");
}