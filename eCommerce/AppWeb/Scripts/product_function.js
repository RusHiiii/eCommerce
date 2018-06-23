jQuery(document).ready(function () {
    jQuery("#ProductName").keyup((evt) => {
        if (jQuery(evt.target).val().length != 0) {
            jQuery("#listOfProducts").find("tbody").find("tr").hide().children("#productLabel[value*='" + jQuery(evt.target).val() + "']").parent("tr").show()
        } else {
            jQuery("#listOfProducts").find("tbody").find("tr").show()
        }
    })
});



