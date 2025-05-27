using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class FraseController : Controller
    {
        // GET: FraseController
        public ActionResult Index()
        {
            return View();
        }

            public ActionResult ContarPalabras(string frase)
            {
                int cantidad = 0;
                if (!string.IsNullOrWhiteSpace(frase))
                {
                    // Elimina puntuaciones básicas y cuenta solo palabras reales
                    var soloTexto = new string(frase.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray());
                    cantidad = soloTexto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                }
                ViewBag.Frase = frase;
                ViewBag.Cantidad = cantidad;
                return View();
            }

    }
}
