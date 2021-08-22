"use strict";
var CompraGrid;
(function (CompraGrid) {
    if (MensajeApp != "") {
        Toast.fire({
            icon: "success", title: MensajeApp
        });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar este registro?", "Eliminar", "warning", "#3085d6", "d33")
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Compra/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    CompraGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(CompraGrid || (CompraGrid = {}));
//# sourceMappingURL=Grid.js.map