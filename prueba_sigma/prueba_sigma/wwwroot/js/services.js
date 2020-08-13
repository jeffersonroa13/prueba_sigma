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
            swal({
                title: "Aviso",
                text: data["message"],
                icon: "error",
            });
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
            swal({
                title: "Aviso",
                text: data["message"],
                icon: "error",
            });
        }
    });
}


function validateForm(me) {
    
    me.name = $("#name").val();
    me.email = $("#email").val();
    me.city = $("#city").val();
    me.state = $("#state").val();
    if (me.name.length == 0 || me.email.length == 0 || me.city.length == 0 || me.state.length == 0) return false;
    if (me.name.length > 50) {
        swal({
            title: "Aviso",
            text: "El maximo del nombre es de 50 caracteres",
            icon: "warning",
        });
        return false;
    }
    if (me.email.length > 30) {
        swal({
            title: "Aviso",
            text: "El maximo del correo es de 30 caracteres",
            icon: "warning",
        });
        return false;
    }
    return true;
}



function sendData()
{
    let me = Object.create(user);
    if (this.validateForm(me)) {
        $("#button_send").attr('disabled', true);
        jQuery.ajax({
            url: "/user/sendData",
            type: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify(me),
            success: function (url, data, callback) {
                $("#button_send").attr('disabled', false);
                if (url["result"]) {
                    swal({
                        title: "Aviso",
                        text: url["message"],
                        icon: "success",
                    });
                } else {
                    swal({
                        title: "Aviso",
                        text: url["message"],
                        icon: "error",
                    });
                }
            }
        });
    } else
    {
        swal({
            title: "Aviso",
            text: "Completa los campos",
            icon: "warning",
        });
    }
}