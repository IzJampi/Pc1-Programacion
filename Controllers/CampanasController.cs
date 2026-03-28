using Microsoft.AspNetCore.Mvc;
using PC1.Models;
using System.Linq;

namespace PC1.Controllers
{
    public class CampanasController : Controller
    {
        // LISTADO
        public IActionResult Index(string categoria, string estado)
        {
            var lista = CampanaData.Lista;

            // Filtro en memoria
            if (!string.IsNullOrEmpty(categoria))
                lista = lista.Where(c => c.Categoria == categoria).ToList();

            if (!string.IsNullOrEmpty(estado))
                lista = lista.Where(c => c.Estado == estado).ToList();

            return View(lista);
        }

        // DETALLE
        public IActionResult Detalle(int id)
        {
            var campana = CampanaData.Lista.FirstOrDefault(c => c.Id == id);
            return View(campana);
        }

        // RESUMEN
        public IActionResult Resumen()
        {
            var lista = CampanaData.Lista;

            ViewBag.Total = lista.Count;
            ViewBag.Vigentes = lista.Count(c => c.Estado == "Vigente");
            ViewBag.Proximas = lista.Count(c => c.Estado == "Próxima");
            ViewBag.Promedio = lista.Average(c => c.DescuentoPct);

            ViewBag.Web = lista.Count(c => c.Canal == "Web");
            ViewBag.App = lista.Count(c => c.Canal == "App");
            ViewBag.Tienda = lista.Count(c => c.Canal == "Tienda");

            return View();
        }
    }
}