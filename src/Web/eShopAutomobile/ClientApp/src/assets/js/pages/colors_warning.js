/* ------------------------------------------------------------------------------
*
*  # Warning palette colors
*
*  Specific JS code additions for colors_warning.html page
*
*  Version: 1.0
*  Latest update: Aug 1, 2018
*
* ---------------------------------------------------------------------------- */

$(function() {


    // Selects
    // ------------------------------

    // Basic select2
    $('.select').select2({
        minimumResultsForSearch: Infinity,
        containerCssClass: 'bg-ey-danger'
    });


    // Select2 ultiselect item color
    $('.select-item-color').select2({
        containerCssClass: 'bg-ey-danger'
    });


    // Select2 dropdown menu color
    $('.select-menu-color').select2({
        containerCssClass: 'bg-ey-danger',
        dropdownCssClass: 'bg-ey-danger'
    });


    // Multiselect
    $('.multiselect').multiselect({
        buttonClass: 'btn bg-ey-danger',
        nonSelectedText: 'Select your state',
        onChange: function() {
            $.uniform.update();
        }
    });


    // SelectBoxIt
    $(".selectbox").selectBoxIt({
        autoWidth: false,
        theme: "bootstrap"
    });


    // Bootstrap select
    $.fn.selectpicker.defaults = {
        iconBase: '',
        tickIcon: 'icon-checkmark-circle'
    }
    $('.bootstrap-select').selectpicker();



    // Notifications
    // ------------------------------

    // jGrowl
    $('.growl-launch').on('click', function () {
        $.jGrowl('I am a well highlighted warning notice..', { theme: 'bg-ey-danger', header: 'Well highlighted' });
    });


    // PNotify
    $('.pnotify-launch').on('click', function () {
        new PNotify({
            title: 'Info Notice',
            text: 'Check me out! I\'m a notice.',
            icon: 'icon-ey-info22',
            animate_speed: 200,
            delay: 5000,
            addclass: 'bg-ey-warning'
        });
    });



    // Form components
    // ------------------------------

    // Switchery toggle
    var switchery = document.querySelector('.switch');
    var init = new Switchery(switchery, {color: '#00a3ae'});


    // Checkboxes and radios
    $(".styled, .multiselect-container input").uniform({
        radioClass: 'choice',
        checkboxClass: 'checker',
        wrapperClass: "border-ey-blue text-ey-warning"
    });


    // File input
    $(".file-styled").uniform({
        fileButtonClass: 'action btn bg-ey-warning'
    });



    // Popups
    // ------------------------------

    // Tooltip
    $('[data-popup=tooltip-custom]').tooltip({
        template: '<div class="tooltip"><div class="bg-ey-danger"><div class="tooltip-arrow"></div><div class="tooltip-inner"></div></div></div>'
    });


    // Popover title
    $('[data-popup=popover-custom]').popover({
        template: '<div class="popover border-ey-red"><div class="arrow"></div><h3 class="popover-title bg-ey-danger"></h3><div class="popover-content"></div></div>'
    });


    // Popover background color
    $('[data-popup=popover-solid]').popover({
        template: '<div class="popover bg-ey-danger"><div class="arrow"></div><h3 class="popover-title"></h3><div class="popover-content"></div></div>'
    });

});
