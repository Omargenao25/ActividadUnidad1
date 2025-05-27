using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class PalindromaController : Controller
    {
        // GET: PalindromaController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Palabra(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                
                return View("Error");
            }

            bool isPalindrome = IsPalindrome(texto.Trim());

            ViewBag.Mensaje = isPalindrome
                ? $"La palabra '{texto.Trim()}' es un palíndromo."
                : $"La palabra '{texto.Trim()}' no es un palíndromo.";

            return View();
        }

        private bool IsPalindrome(string word)
        {
           
            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }

    }
}
