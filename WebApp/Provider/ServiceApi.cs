using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp
{
    public class ServiceApi
    {
        private readonly HttpClient client;

        public ServiceApi(HttpClient client)
        {
            this.client = client;
        }

        #region Clientes

        public async Task<IEnumerable<ClientesEntity>> ClientesGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ClientesEntity>>("api/Clientes");

            return result;       
        
        
        }

        public async Task<IEnumerable<ClientesEntity>> ClientesGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ClientesEntity>>("api/Clientes/Lista");

            return result;

        }

        public async Task<ClientesEntity> ClientesGetById(int id)
        {
            var result = await client.ServicioGetAsync<ClientesEntity>("api/Clientes/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);
           
            return result;


        }






        #endregion

        #region Usuario

        public async Task<UsuariosEntity> UsuarioLogin(UsuariosEntity entity)
        {

            var result = await client.ServicioPostAsync<UsuariosEntity>("api/Usuarios/Login", entity);

            return result;
        }

        #endregion

        #region Productos

        public async Task<IEnumerable<ProductoEntity>> ProductosGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ProductoEntity>>("api/Productos");

            return result;


        }

        public async Task<IEnumerable<ProductoEntity>> ProductosGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ProductoEntity>>("api/Productos/Lista");

            return result;

        }

        public async Task<ProductoEntity> ProductosGetById(int id)
        {
            var result = await client.ServicioGetAsync<ProductoEntity>("api/Productos/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;


        }






        #endregion

        #region Compras

        public async Task<IEnumerable<CompraEntity>> ComprasGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<CompraEntity>>("api/Compras");

            return result;


        }

        public async Task<IEnumerable<CompraEntity>> ComprasGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<CompraEntity>>("api/Compras/Lista");

            return result;

        }

        public async Task<CompraEntity> ComprasGetById(int id)
        {
            var result = await client.ServicioGetAsync<CompraEntity>("api/Compras/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;


        }






        #endregion


    

    }
}
