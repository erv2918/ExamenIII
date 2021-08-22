using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WepApp.Pages.Compra
{
    public class EditModel : PageModel
    {
        private readonly ICompraService compraService;
        private readonly IClientesService clientesService;
        private readonly IProductoService productoService;
        public EditModel(ICompraService compraService, IClientesService clientesService, IProductoService productoService )
        {
            this.compraService = compraService;
            this.clientesService = clientesService;
            this.productoService = productoService;
        }
        [BindProperty]
        public CompraEntity Entity { get; set; } = new CompraEntity();
        public IEnumerable<ClientesEntity> ClienteLista { get; set; } = new List<ClientesEntity>();
        public IEnumerable<ProductoEntity> ProductoLista { get; set; } = new List<ProductoEntity>();
        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await compraService.GetById(new() { IdCompra = id });
                }
                ClienteLista = await clientesService.GetLista();
                ProductoLista = await productoService.GetLista();

                return Page();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (Entity.IdCompra.HasValue)
                {
                    //Actualizar 
                    var result = await compraService.Update(Entity);

                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "Se actualizó correctamente";
                }
                else
                {
                    //Nuevo 
                    var result = await compraService.Create(Entity);

                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "Se agregó correctamente";
                }
                return RedirectToPage("Grid");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
