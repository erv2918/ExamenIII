namespace ProductoEdit {


    var Entity = $("#AppEdit").data("entity");

    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit",
            Entity: Entity,

        },

        methods: {



            ProductoServicio(entity) {
                console.log(entity);
                if (entity.ProductoId == null) {
                    return App.AxiosProvider.ProductosGuardar(entity);
                } else {
                    return App.AxiosProvider.ProductosActualizar(entity);
                }
            },
            Save() {

                if (BValidateData(this.Formulario)) {

                    Loading.fire("Guardando");

                    this.ProductoServicio(this.Entity).then(data => {

                        Loading.close();

                        if (data.CodeError == 0) {
                            Toast.fire({ title: "Se guardo sastifactoriamente!", icon: "success" })
                                .then(() => window.location.href = "Producto/Grid")
                        } else {
                            Toast.fire({ title: data.MsgError, icon: "error" });

                        }


                    }).catch(c => console.log(c));



                } else {
                    Toast.fire({ title: "Por favor complete los campos requeridos!", icon: "error" });
                }

            }


        },
        mounted() {


            CreateValidator(this.Formulario);

        }

    });

    Formulario.$mount("#AppEdit")
}