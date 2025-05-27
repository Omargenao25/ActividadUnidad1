using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class PrimerEjercicioController : Controller
    {
        // GET: PrimerEjercicioController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inicio()
        {
            ViewBag.Mensaje = "Hola! Soy Omar Hernandez, Matricula: MT-2023-00455."; 
            return View();
        }

<<<<<<< HEAD
        // GET: PrimerEjercicioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrimerEjercicioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrimerEjercicioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrimerEjercicioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrimerEjercicioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrimerEjercicioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrimerEjercicioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
=======
>>>>>>>  primer ejercicio
    }
}
