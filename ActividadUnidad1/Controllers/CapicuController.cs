using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CapicuController : Controller
    {
        // GET: CapicuController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Verificar(int numero)
        {
            bool esCapicu = EsNumeroCapicu(numero);

            ViewBag.Numero = numero;
            ViewBag.EsCapicu = esCapicu;

            return View();
        }

        private bool EsNumeroCapicu(int numero)
        {
            string numeroString = numero.ToString();
            int longitud = numeroString.Length;

            if (longitud < 2)
                return false;

            int mitad = longitud / 2;
            string primeraMitad = numeroString.Substring(0, mitad);
            string segundaMitad = numeroString.Substring(mitad);

            return primeraMitad == segundaMitad;
        }
        
    }
}
