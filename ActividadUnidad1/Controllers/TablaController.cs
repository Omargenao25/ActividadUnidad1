using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class TablaController : Controller
    {
        // GET: TablaController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Multiplicar(int numero)
        {
            List<string> tablaMultiplicar = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                tablaMultiplicar.Add($"{numero} x {i} = {resultado}");
            }

            ViewBag.Numero = numero;
            ViewBag.TablaMultiplicar = tablaMultiplicar;
            return View();
        }
    }
}
