using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CorreoController : Controller
    {
        // GET: CorreoController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dominio(string email)
        {
            string dominio = ObtenerDominio(email);

            ViewBag.Email = email;
            ViewBag.Dominio = dominio;

            return View();
        }

        private string ObtenerDominio(string email)
        {
            // Dividir la dirección de correo electrónico en nombre de usuario y dominio
            string[] partes = email.Split('@');

            if (partes.Length == 2)
            {
                return partes[1];
            }
            else
            {
                return "Dirección de correo electrónico inválida";
            }
        }

        
    }
}
