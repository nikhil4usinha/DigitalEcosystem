/* ------------------------------------------------------------------------------
*
*  # Buttons extension for Datatables. Init examples
*
*  Specific JS code additions for datatable_extension_buttons_init.html page
*
*  Version: 1.0
*  Latest update: Nov 9, 2018
*
* ---------------------------------------------------------------------------- */

$(function() {


    // Table setup
    // ------------------------------

    // Setting datatable defaults
    $.extend( $.fn.dataTable.defaults, {
        autoWidth: false,
        dom: '<"datatable-header"fBl><"datatable-scroll-wrap"t><"datatable-footer"ip>',
        language: {
            search: '<span>Filter:</span> _INPUT_',
            searchPlaceholder: 'Type to filter...',
            lengthMenu: '<span>Show:</span> _MENU_',
            paginate: { 'first': 'First', 'last': 'Last', 'next': '&rarr;', 'previous': '&larr;' }
        }
    });


    // Basic initialization
    $('.datatable-button-init-basic').DataTable({
        buttons: {
            dom: {
                button: {
                    className: 'btn btn-ey-default'
                }
            },
            buttons: [
                {extend: 'copy'},
                {extend: 'csv'},
                {extend: 'excel'},
                {extend: 'pdf'},
                {extend: 'print'}
            ]
        }
    });


    // Custom button
    $('.datatable-button-init-custom').DataTable({
        buttons: [
            {
                text: 'Custom button',
                className: 'btn bg-ey-yellow',
                action: function(e, dt, node, config) {
                    swal({
                        title: "Good job!",
                        text: "Custom button activated",
                        confirmButtonColor: "#808080",
                        type: "success"
                    });
                }
            }
        ]
    });


    // Buttons collection
    $('.datatable-button-init-collection').DataTable({
        buttons: [
            {
                extend: 'collection',
                text: '<i class="icon-three-bars"></i> <span class="caret"></span>',
                className: 'btn bg-ey-grey-alt btn-icon',
                buttons: [
                    {
                        text: 'Toggle first name',
                        action: function ( e, dt, node, config ) {
                            dt.column( 0 ).visible( ! dt.column( 0 ).visible() );
                        }
                    },
                    {
                        text: 'Toggle status',
                        action: function ( e, dt, node, config ) {
                            dt.column( -2 ).visible( ! dt.column( -2 ).visible() );
                        }
                    }
                ]
            }
        ]
    });


    // Page length
    $('.datatable-button-init-length').DataTable({
        dom: '<"datatable-header"fB><"datatable-scroll-wrap"t><"datatable-footer"ip>',
        lengthMenu: [
            [ 10, 25, 50, -1 ],
            [ '10 rows', '25 rows', '50 rows', 'Show all' ]
        ],
        buttons: [
            {
                extend: 'pageLength',
                className: 'btn bg-ey-grey'
            }
        ]
    });



    // External table additions
    // ------------------------------

    // Enable Select2 select for the length option
    $('.dataTables_length select').select2({
        minimumResultsForSearch: Infinity,
        width: 'auto'
    });
    
});
