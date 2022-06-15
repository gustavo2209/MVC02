function tutorialesIns() {
    $("#tbl_tutoriales_accion").val("INS");
    $("#tbl_tutoriales_titulo").val("");
    $("#tbl_tutoriales_precio").val("");

    $("#dlg_tutoriales_title").text("Nuevo Tutorial");
    $("#dlg_tutoriales_errores").html("");

    $("#dlg_tutoriales").modal("show");
}

function tutorialesUpd(idtutorial) {
    $("#tbl_tutoriales_accion").val("UPD");
    $("#tbl_tutoriales_idtutorial").val(idtutorial);
    $("#tbl_tutoriales_titulo").val($("#titulo_" + idtutorial).text().trim());
    $("#tbl_tutoriales_tipo").val($("#tipo_" + idtutorial).text().trim());
    $("#tbl_tutoriales_precio").val($("#precio_" + idtutorial).text().trim());

    $("#dlg_tutoriales_title").text("Actualizar Tutorial");
    $("#dlg_tutoriales_errores").html("");
    $("#dlg_tutoriales").modal("show");
}

function tutorialesInsUpd() {
    var accion = $("#tbl_tutoriales_accion").val();
    var idtutorial = $("#tbl_tutoriales_idtutorial").val();
    var titulo = $("#tbl_tutoriales_titulo").val();
    var tipo = $("#tbl_tutoriales_tipo").val();
    var precio = $("#tbl_tutoriales_precio").val();

    // VALIDANDO
    var msg = "<ul>";
    if ($.trim(titulo) === "") {
        msg += "<li>Ingrese título de tutorial</li>";
    }
    if (!$.isNumeric(precio)) {
        msg += "<li>Debe ingresar valor númerico</li>";
    }
    msg += "</ul>";

    if (msg.length > 9) {
        $("#dlg_tutoriales_errores").html(msg);
    } else {
        window.location = "../Home/Index?accion=" + accion + "&idtutorial=" + idtutorial + "&titulo=" + titulo + "&tipo=" + tipo + "&precio=" + precio;
    }
}

function tutorialesDel(idtutorial) {
    var titulo = $("#titulo_" + idtutorial).text();
    $("#dlg_confirm_title").text("Retiro de Tutorial");
    $("#dlg_confirm_msg").html("¿Eliminar " + titulo + "?");
    $("#dlg_confirm_dato1").val("DEL");
    $("#dlg_confirm_dato2").val(idtutorial);
    $("#dlg_confirm_error").hide();
    $("#dlg_confirm").modal("show");
}

function dlg_confirm_confirm() {
    var accion = $("#dlg_confirm_dato1").val();

    if (accion === "DEL") {
        var idtutorial = $("#dlg_confirm_dato2").val();

        window.location = "../Home/Index?accion=" + accion + "&idtutorial=" + idtutorial;
    } else if(accion === "OTRA_ACCION") {
        // para el futuro
    }
}