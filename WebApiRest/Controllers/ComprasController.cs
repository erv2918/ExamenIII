using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {

        private readonly ICompraService compraService;

        public ComprasController(ICompraService compraService)
        {
            this.compraService = compraService;
        }



        [HttpGet]
        public async Task<IEnumerable<CompraEntity>> Get()
        {
            try
            {
                return await compraService.Get();
            }
            catch (Exception ex)
            {

                return new List<CompraEntity>();
            }
        }


        [HttpGet("Lista")]
        public async Task<IEnumerable<CompraEntity>> GetLista()
        {
            try
            {
                return await compraService.Get();
            }
            catch (Exception ex)
            {

                return new List<CompraEntity>();
            }
        }

        [HttpGet("{id}")]
        public async Task<CompraEntity> GetById(int id)
        {
            try
            {
                return await compraService.GetById(new CompraEntity { ProductoId = id });
            }
            catch (Exception ex)
            {

                return new CompraEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }




        [HttpPost]
        public async Task<DBEntity> Create(CompraEntity entity)
        {
            try
            {
                return await compraService.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

        [HttpPut]
        public async Task<DBEntity> Update(CompraEntity entity)
        {
            try
            {
                return await compraService.Update(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }


        [HttpDelete("{id}")]
        public async Task<DBEntity> Delete(int id)
        {
            try
            {
                return await compraService.Delete(new CompraEntity() { ProductoId = id });
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }
        }

    }
}
