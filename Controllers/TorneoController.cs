using BattleFight.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BattleFight.Models;
using BattleFight.Services;

namespace BattleFight.Controllers
{
    public class TorneoController : Controller
    {
        private Service service;

        public TorneoController()
        {
            service = new Service();
        }


        // GET: TorneoController
        public ActionResult Index()
        {
            var model = service.mostrarTorneo();
            return View(model);
        }

        // POST: TorneoController/Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string UsuarioResponsable)
        {
            var model = new List<Torneo>();
            if (!string.IsNullOrEmpty(UsuarioResponsable))
                model = service.filtroUsuario(UsuarioResponsable);
            else model = service.mostrarTorneo();
            return View(model);
        }

        // GET: ProductoController/Create
        public ActionResult Create()
        {
            ViewBag.usuarios = service.mostrarTorneo();
            return View();
        }

        // POST: ProductoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Torneo torneo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.agregarTorneo(torneo);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        // GET: ProductoController/Edit/5
        public ActionResult Edit(int id)
        {
            var torneoBuscado = service.buscarTorneo(id);
            return View(torneoBuscado);
        }

        // POST: ProductoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Torneo torneoActualizado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.actualizarTorneo(torneoActualizado);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        // GET: ProductoController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var torneoBuscado = service.buscarTorneo(id);
                service.eliminarTorneo(torneoBuscado);
                return RedirectToAction("Index");
            }
            catch (Exception) { }
            return View();
        }
    }
}
