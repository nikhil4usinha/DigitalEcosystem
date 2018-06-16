/* ------------------------------------------------------------------------------
*
*  # Styled checkboxes, radios and file input
*
*  Specific JS code additions for form_checkboxes_radios.html page
*
*  Version: 1.0
*
* ---------------------------------------------------------------------------- */

$(function() {


    // Switchery
    // ------------------------------

    // Initialize multiple switches
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

    // Colored switches
    var primary = document.querySelector('.switchery-ey-primary');
    var switchery = new Switchery(primary, { color: '#646464' });

    var danger = document.querySelector('.switchery-ey-danger');
    var switchery = new Switchery(danger, { color: '#f04c3e' });

    var warning = document.querySelector('.switchery-ey-warning');
    var switchery = new Switchery(warning, { color: '#00a3ae' });

    var info = document.querySelector('.switchery-ey-info');
    var switchery = new Switchery(info, { color: '#ac98db'});



    // Checkboxes/radios (Uniform)
    // ------------------------------

    // Default initialization
    $(".styled, .multiselect-container input").uniform({
        radioClass: 'choice'
    });

    // File input
    $(".file-styled").uniform({
        wrapperClass: 'bg-ey-grey-alt',
        fileButtonHtml: '<i class="icon-file-plus"></i>'
    });


    //
    // Contextual colors
    //

    // Primary
    $(".control-ey-primary").uniform({
        radioClass: 'choice',
        wrapperClass: 'border-ey-grey-alt text-ey-grey-alt'
    });

    // Danger
    $(".control-ey-danger").uniform({
        radioClass: 'choice',
        wrapperClass: 'border-ey-red text-ey-red'
    });

    // Success
    $(".control-ey-success").uniform({
        radioClass: 'choice',
        wrapperClass: 'border-ey-green text-ey-green'
    });

    // Warning
    $(".control-ey-warning").uniform({
        radioClass: 'choice',
        wrapperClass: 'border-ey-blue text-ey-warning'
    });

    // Info
    $(".control-ey-info").uniform({
        radioClass: 'choice',
        wrapperClass: 'border-ey-lilac text-ey-info'
    });

    // Custom color
    $(".control-custom").uniform({
        radioClass: 'choice',
        wrapperClass: 'border-ey-purple text-ey-purple'
    });



    // Bootstrap switch
    // ------------------------------

    $(".switch").bootstrapSwitch();
    
});
