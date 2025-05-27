using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class NumeroController : Controller
    {
        // GET: NumeroController
        public ActionResult Index()
        {
            return View();
        }
            public ActionResult ParImpar(int? numero)
            {
                if (numero == null)
                {
                    ViewBag.Mensaje = "Por favor, proporciona un número en la URL. Ej: /Numero/ParImpar?numero=7";
                }
                else
                {
                    ViewBag.Mensaje = (numero % 2 == 0)
                        ? $"El número {numero} es par."
                        : $"El número {numero} es impar.";
                }

                return View();
            }

    }
}
