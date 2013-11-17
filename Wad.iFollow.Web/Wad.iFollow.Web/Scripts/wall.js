function mainpage() { }
function ceva() {
    $('#a').click(function () {
        debugger;
        var url = "Views/Wall/_SettingsModal.cshtml";
        $.get(url, function (data) {
            $('#myModalContainer').html(data);
            $('#myModal').modal('show');
        });
    });
}