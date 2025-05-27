using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class ClaveController : Controller
    {
        // GET: ClaveController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Segura(string clave)
        {
            bool esSegura = VerificarClaveSegura(clave);

            ViewBag.Clave = clave;
            ViewBag.EsSegura = esSegura;

            return View();
        }

        private bool VerificarClaveSegura(string clave)
        {
            // Verificar si la clave cumple con los requisitos de seguridad:
            // - Mínimo 8 caracteres
            // - Al menos una mayúscula
            // - Al menos un número

            if (string.IsNullOrEmpty(clave) || clave.Length < 8)
                return false;

            bool tieneMayuscula = false;
            bool tieneNumero = false;

            foreach (char c in clave)
            {
                if (char.IsUpper(c))
                    tieneMayuscula = true;
                else if (char.IsDigit(c))
                    tieneNumero = true;
            }

            return tieneMayuscula && tieneNumero;
        }

        
    }
}
