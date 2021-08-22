
namespace App.AxiosProvider   {

    //export const GuardarEmpleado = () => axios.get<Entity.DBEntity>("aplicacion").then(({data})=>data );



    export const ClientesEliminar = (id) => ServiceApi.delete<DBEntity>("api/Clientes/" + id).then(({ data }) => data);
    export const ClientesGuardar = (entity) => ServiceApi.post<DBEntity>("api/Clientes", entity).then(({ data }) => data);
    export const ClientesActualizar = (entity) => ServiceApi.put<DBEntity>("api/Clientes", entity).then(({ data }) => data);

    export const ProductosEliminar = (id) => ServiceApi.delete<DBEntity>("api/Productos/" + id).then(({ data }) => data);
    export const ProductosGuardar = (entity) => ServiceApi.post<DBEntity>("api/Productos", entity).then(({ data }) => data);
    export const ProductosActualizar = (entity) => ServiceApi.put<DBEntity>("api/Productos", entity).then(({ data }) => data);

    export const ComprasEliminar = (id) => ServiceApi.delete<DBEntity>("api/Compras/" + id).then(({ data }) => data);
    export const ComprasGuardar = (entity) => ServiceApi.post<DBEntity>("api/Compras", entity).then(({ data }) => data);
    export const ComprasActualizar = (entity) => ServiceApi.put<DBEntity>("api/Compras", entity).then(({ data }) => data);

    export const UsuarioRegistrar = (entity) => ServiceApi.post<DBEntity>("api/Usuarios/Registrar", entity).then(({ data }) => data);
    export const UsuarioLogin = (entity) => axios.post<DBEntity>("Login", entity).then(({ data }) => data);


    
}




