$(document).ready(function () {
    $("#hauntDialog").dialog({
        autoOpen: false,
        height: 350,
        width: 350,
        modal: true,
        overlay: { opacity: 0.5, background: 'black' },
        position: 'center',
        buttons: {
            "Haunt": function () {
                $('#hauntForm').submit();
            },
            Cancel: function () {
                $(this).dialog("close");
            }
        },
        close: function () {
        }
    });

    $('#hauntForm').ajaxForm({
        url: '/ghost/haunt',
        success: onHauntSuccess,
        type: 'POST',
        cache: false
    });
});

function onHauntSuccess(result) {
    if (result.Status == 'OK') {
        // Success! Parse the JSON result and display the text.
        $('#graveyardStatus').text("You're haunting " + result.Name + " for " + result.Days + " days!");
        $('#hauntDialog').dialog("close");
    }
    else if (result.Status != null) {
        // Display the status.
        $('#status').text(result.Status);
    }
    else {
        // Logged-in session lost?
        document.location = '/';
    }
}