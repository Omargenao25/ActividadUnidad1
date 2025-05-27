using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class TemperaturaController : Controller
    {
        // GET: TemperaturaController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Convertir(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;

            ViewBag.Celsius = celsius;
            ViewBag.Fahrenheit = fahrenheit;

            return View();
        }

    }
}
