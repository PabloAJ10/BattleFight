using BattleFight.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BattleFight.Models;

namespace BattleFight.Controllers
{
    public class EquiposController : Controller
    {
        private Service service;

        public EquiposController()
        {
            service = new Service();
        }


        // GET: ProductoController
        public ActionResult Index()
        {
            var model = service.mostrarEquipo();
            return View(model);
        }

        // POST: ProductoController/Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string UsuarioResponsable)
        {
            var model = new List<Equipo>();
            if (!string.IsNullOrEmpty(UsuarioResponsable))
                model = service.filtroUsuario2(UsuarioResponsable);
            else model = service.mostrarEquipo();
            return View(model);
        }


        // GET: ProductoController/Create
        public ActionResult Create()
        {
            ViewBag.usuarios = service.mostrarEquipo();
            return View();
        }

        // POST: ProductoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Equipo equipo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.agregarEquipo(equipo);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        // GET: ProductoController/Edit/5
        public ActionResult Edit(string categoria)
        {
            var equipoBuscado = service.buscarEquipo(categoria);
            return View(equipoBuscado);
        }

        // POST: ProductoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Equipo equipoActualizado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.actualizarEquipo(equipoActualizado);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        
        // GET: ProductoController/Delete/5
        
        
        }
        
    }
