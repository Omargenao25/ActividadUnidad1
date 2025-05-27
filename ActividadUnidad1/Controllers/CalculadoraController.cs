using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: CalculadoraController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sumar(int a, int b)
        {
            var resultado = a + b;
            return View("Resultado", resultado);
        }

        // Acción para restar
        public ActionResult Restar(int a, int b)
        {
            var resultado = a - b;
            return View("Resultado", resultado);
        }

        // Acción para multiplicar
        public ActionResult Multiplicar(int a, int b)
        {
            var resultado = a * b;
            return View("Resultado", resultado);
        }

        // Acción para dividir
        public ActionResult Dividir(int a, int b)
        {
            if (b == 0)
            {
                return View("Error", "No se puede dividir entre cero.");
            }
            var resultado = (double)a / b;
            return View("Resultado", resultado);
        }

    
    }
}
