const user =
{
    state: "",
    city: "",
    name: "",
    email: "",
}


$(document).ready(function () {

    $.get("Cities/States", function (data, status) {
        if (data["result"]) {
            data["data"].forEach(item => {
                $('#state').append(new Option(item, item))
            });
        } else {
            alert(data["message"]);
        }
    });
});

function getCitiesByState() {
    let state = $("#state").val();
    $('#city').children('option:not(:first)').remove();
    $.get(`Cities/GetCitiesByStateId?state=${state}`, function (data, status) {
        if (data["result"]) {
            data["data"].forEach(item => {
                $('#city').append(new Option(item, item))
            });
        } else {
            alert(data["message"]);
        }
    });
}


function validateForm(me) {
    
    me.name = $("#name").val();
    me.email = $("#email").val();
    me.city = $("#city").val();
    me.state = $("#state").val();
    if (me.name.length == 0 || me.email.length == 0 || me.city.length == 0 || me.state.length == 0) return false;
    if (me.name.length > 50) return false;
    if (me.name.length > 30) return false;
    return true;
}



function sendData()
{
    let me = Object.create(user);
    if (this.validateForm(me)) {
        jQuery.ajax({
            url: "/user/sendData",
            type: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify(me),
            success: function (url, data, callback) {
                if (data["result"]) {

                } else {
                    alert(data["result"]);
                }
            }
        });
    } else
    {
        alert("completa la infomación del formulario");
    }
}