/* ------------------------------------------------------------------------------
*
*  # Input groups
*
*  Specific JS code additions for form_input_groups.html page
*
*  Version: 1.0
*  Latest update: Aug 1, 2018
*
* ---------------------------------------------------------------------------- */

$(function() {


    // Checkboxes/radios in addons
    // ------------------------------

    // Switchery
    if (Array.prototype.forEach) {
        var elems = Array.prototype.slice.call(document.querySelectorAll('.switchery'));
        elems.forEach(function(html) {
            var switchery = new Switchery(html);
        });
    }
    else {
        var elems = document.querySelectorAll('.switchery');
        for (var i = 0; i < elems.length; i++) {
            var switchery = new Switchery(elems[i]);
        }
    }


    // Styled checkboxes/radios
    $(".styled, .multiselect-container input").uniform({
        radioClass: 'choice'
    });

    // Update uniform when select between styled and unstyled
    $('.input-group-addon input[type=radio]').on('click', function() {
        $.uniform.update("[name=addon-radio]");
    });



    // Touchspin spinners
    // ------------------------------

    // Basic example
    $(".touchspin-basic").TouchSpin({
        postfix: '<i class="icon-paragraph-justify2"></i>'
    });


    // Postfix
    $(".touchspin-postfix").TouchSpin({
        min: 0,
        max: 100,
        step: 0.1,
        decimals: 2,
        postfix: '%'
    });


    // Prefix
    $(".touchspin-prefix").TouchSpin({
        min: 0,
        max: 100,
        step: 0.1,
        decimals: 2,
        prefix: '$'
    });


    // Init with empty values
    $(".touchspin-empty").TouchSpin();


    // Disable mousewheel
    $(".touchspin-no-mousewheel").TouchSpin({
        mousewheel: false
    });


    // Incremental/decremental steps
    $(".touchspin-step").TouchSpin({
        step: 10
    });


    // Set value
    $(".touchspin-set-value").TouchSpin({
        initval: 40
    });


    // Inside button group
    $(".touchspin-button-group").TouchSpin({
        prefix: "pre",
        postfix: "post"
    });


    // Vertical spinners
    $(".touchspin-vertical").TouchSpin({
        verticalbuttons: true,
        verticalupclass: 'icon-arrow-up22',
        verticaldownclass: 'icon-arrow-down22'
    });



    // Touchspin colors
    // ------------------------------

    //
    // Addons
    //

    // Default
    $(".touchspin-addon-ey-default").TouchSpin({
        prefix: '<i class="icon-accessibility"></i>',
        postfix: '<i class="icon-paragraph-justify2"></i>'
    });

    // Primary
    $(".touchspin-addon-ey-primary").TouchSpin({
        prefix_extraclass: 'input-group-addon-ey-primary',
        postfix_extraclass: 'input-group-addon-ey-primary',
        prefix: '<i class="icon-accessibility"></i>',
        postfix: '<i class="icon-paragraph-justify2"></i>'
    });

    // Danger
    $(".touchspin-addon-ey-danger").TouchSpin({
        prefix_extraclass: 'input-group-addon-ey-danger',
        postfix_extraclass: 'input-group-addon-ey-danger',
        prefix: '<i class="icon-accessibility"></i>',
        postfix: '<i class="icon-paragraph-justify2"></i>'
    });

    // Success
    $(".touchspin-addon-ey-success").TouchSpin({
        prefix_extraclass: 'input-group-addon-ey-success',
        postfix_extraclass: 'input-group-addon-ey-success',
        prefix: '<i class="icon-accessibility"></i>',
        postfix: '<i class="icon-paragraph-justify2"></i>'
    });

    // Warning
    $(".touchspin-addon-ey-warning").TouchSpin({
        prefix_extraclass: 'input-group-addon-ey-warning',
        postfix_extraclass: 'input-group-addon-ey-warning',
        prefix: '<i class="icon-accessibility"></i>',
        postfix: '<i class="icon-paragraph-justify2"></i>'
    });

    // Info
    $(".touchspin-addon-ey-info").TouchSpin({
        prefix_extraclass: 'input-group-addon-ey-info',
        postfix_extraclass: 'input-group-addon-ey-info',
        prefix: '<i class="icon-accessibility"></i>',
        postfix: '<i class="icon-paragraph-justify2"></i>'
    });


    //
    // Buttons
    //

    // Default
    $(".touchspin-button-ey-default").TouchSpin({
        prefix: '<i class="icon-accessibility"></i>',
        postfix: '<i class="icon-paragraph-justify2"></i>',
        buttondown_class: "btn btn-ey-default",
        buttonup_class: "btn btn-ey-default"
    });

    // Primary
    $(".touchspin-button-ey-primary").TouchSpin({
        prefix: '<i class="icon-accessibility"></i>',
        postfix: '<i class="icon-paragraph-justify2"></i>',
        buttondown_class: "btn bg-ey-yellow",
        buttonup_class: "btn bg-ey-yellow"
    });

    // Danger
    $(".touchspin-button-ey-danger").TouchSpin({
        prefix: '<i class="icon-accessibility"></i>',
        postfix: '<i class="icon-paragraph-justify2"></i>',
        buttondown_class: "btn btn-ey-danger",
        buttonup_class: "btn btn-ey-danger"
    });

    // Success
    $(".touchspin-button-ey-success").TouchSpin({
        prefix: '<i class="icon-accessibility"></i>',
        postfix: '<i class="icon-paragraph-justify2"></i>',
        buttondown_class: "btn btn-ey-success",
        buttonup_class: "btn btn-ey-success"
    });

    // Warning
    $(".touchspin-button-ey-warning").TouchSpin({
        prefix: '<i class="icon-accessibility"></i>',
        postfix: '<i class="icon-paragraph-justify2"></i>',
        buttondown_class: "btn btn-ey-warning",
        buttonup_class: "btn btn-ey-warning"
    });

    // Info
    $(".touchspin-button-ey-info").TouchSpin({
        prefix: '<i class="icon-accessibility"></i>',
        postfix: '<i class="icon-paragraph-justify2"></i>',
        buttondown_class: "btn bg-ey-yellow",
        buttonup_class: "btn bg-ey-yellow"
    });
    
});
