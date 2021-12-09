// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(function () {

    let ajaxFormSubmit = function () {
        const $form = $(this);
        const options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        }
        $.ajax(options.done(function (data) {
            const $target = $($form.attr("data-otf-target"));
            $target.replaceWith(data);
        }));
        return false;

    };
    const createAutocomplete = function () {
        const $input = $(this);
        const options = {
            source: $input.attr("data-otf-autocomplete")
        };
        $input.autocomplete(options);
    };

    $("form [data-otf-ajax='true']").submit(ajaxFormSubmit);
    $("input[data-otf-autocomplete]").each(createAutocomplete);


});
