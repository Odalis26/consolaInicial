﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplicationTest.Data;
using WebApplicationTest.Data.Emptity;

namespace WebApplicationTest.Controllers
{
    public class EjemploController : Controller
    {
        readonly ApplicationDbContext _context;
        public EjemploController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EjemploController
        public ActionResult TodoEnUno()
        { 
            return View(_context.Empleados.ToList());
        }

        // GET: EjemploController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EjemploController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EjemploController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public bool Create(Empleado empleado)
        {
            try
            {
                _context.Add(empleado);
                _context.SaveChanges();
                return true;


            }
            catch
            {
                return false;
            }
        }

        // GET: EjemploController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EjemploController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(TodoEnUno));
            }
            catch
            {
                return View();
            }
        }

        // GET: EjemploController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EjemploController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(TodoEnUno));
            }
            catch
            {
                return View();
            }
        }
    }
}
