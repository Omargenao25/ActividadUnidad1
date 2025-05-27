using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class AñoController : Controller
    {
        // GET: AñoController
        public ActionResult Index()
        {
            return View();
        }
       
            public ActionResult Bisiesto(int año)
            {
                bool esBisiesto = EsAñoBisiesto(año);

                ViewBag.Año = año;
                ViewBag.EsBisiesto = esBisiesto;

                return View();
            }

            private bool EsAñoBisiesto(int año)
            {
                
                return (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0));
            }


    }

}