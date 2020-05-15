function add_and_remove_button_clicks(add_url, remove_url, item_id) {
    $("#add-"+item_id).click(function () {
        $.post({
            url: add_url,
            data: { id: item_id }
        }).done(function () {
            reload_div("#cart-amount-" + item_id)
        });
    });
    $("#remove-"+item_id).click(function () {
        $.post({
            url: remove_url,
            data: { id: item_id }
        }).done(function () {
            reload_div("#cart-amount-" + item_id);
        });
    });
}

function reload_div(div_id) {
    $(div_id).load(location.href + " " + div_id + ">*", "");
}

function highlight_div(div_id) {
    $(div_id).mouseenter(function (event) {
        this.style.border = 'solid 10px';
    });
    $(div_id).mouseleave(function (event) {
        this.style.border = 'solid 1px';
    });
}