using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Medistorial.Core;
using Medistorial.Data.EntityFrameworkCore;
using Medistorial.Services.Specialities;

namespace Medistorial.MVC.Controllers.Specialities
{
    [Area("Admin")]
    public class SpecialitiesController : Controller
    {
        private readonly ISpecialityAppService _service;

        public SpecialitiesController(ISpecialityAppService service)
        {
            _service = service;
        }

        // GET: Admin/Specialities
        public async Task<IActionResult> Index()
        {
            var specialities = _service.GetAll();
            return View(specialities);
        }

        // GET: Admin/Specialities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speciality = _service.Find(id);                
            if (speciality == null)
            {
                return NotFound();
            }

            return View(speciality);
        }

        // GET: Admin/Specialities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Specialities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id")] Speciality speciality)
        {
            if (ModelState.IsValid)
            {
                _service.Add(speciality);
                _service.SaveChanges();                
                return RedirectToAction(nameof(Index));
            }
            return View(speciality);
        }

        // GET: Admin/Specialities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speciality = _service.Find(id);
            if (speciality == null)
            {
                return NotFound();
            }
            return View(speciality);
        }

        // POST: Admin/Specialities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id")] Speciality speciality)
        {
            if (id != speciality.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _service.Update(speciality);
                    _service.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecialityExists(speciality.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(speciality);
        }

        // GET: Admin/Specialities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speciality = _service.Find(id);                
            if (speciality == null)
            {
                return NotFound();
            }

            return View(speciality);
        }

        // POST: Admin/Specialities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var speciality = _service.Find(id);
            _service.Delete(speciality);
            _service.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecialityExists(int id)
        {
            return _service.Find(id) != null;
        }
    }
}
