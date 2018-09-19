using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Medistorial.Core;
using Medistorial.Data.EntityFrameworkCore;
using Medistorial.Services.Medics;
using Medistorial.Services.Specialities;

namespace Medistorial.MVC.Controllers.Medics
{
    public class MedicsController : Controller
    {
        private readonly IMedicAppService _service;
        private readonly ISpecialityAppService _specialityAppService;

        public MedicsController(IMedicAppService service, ISpecialityAppService specialityAppService)
        {
            _service = service;
            _specialityAppService = specialityAppService;
        }

        // GET: Medics
        public async Task<IActionResult> Index()
        {
            var list = _service.GetAll();
            return View(list);
        }

        // GET: Medics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medic = _service.Find(id);
                //.Include(m => m.Speciality)
                
            if (medic == null)
            {
                return NotFound();
            }

            return View(medic);
        }

        // GET: Medics/Create
        public IActionResult Create()
        {
            ViewData["SpecialityId"] = new SelectList(_specialityAppService.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Medics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Medic medic)
        {
            if (ModelState.IsValid)
            {
                _service.Add(medic);
                _service.SaveChanges();                
                return RedirectToAction(nameof(Index));
            }
            ViewData["SpecialityId"] = new SelectList(_specialityAppService.GetAll(), "Id", "Name", medic.SpecialityId);
            return View(medic);
        }

        // GET: Medics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medic = _service.Find(id);
            if (medic == null)
            {
                return NotFound();
            }
            ViewData["SpecialityId"] = new SelectList(_specialityAppService.GetAll(), "Id", "Name", medic.SpecialityId);
            return View(medic);
        }

        // POST: Medics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,LastName,Address,Phone,Mobile,Description,SpecialityId,Id")] Medic medic)
        {
            if (id != medic.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _service.Update(medic);
                    _service.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicExists(medic.Id))
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
            ViewData["SpecialityId"] = new SelectList(_specialityAppService.GetAll(), "Id", "Name", medic.SpecialityId);
            return View(medic);
        }

        // GET: Medics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medic = _service.Find(id);
                //.Include(m => m.Speciality)
                
            if (medic == null)
            {
                return NotFound();
            }

            return View(medic);
        }

        // POST: Medics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medic = _service.Find(id);
            _service.Delete(medic);
            _service.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicExists(int id)
        {
            return _service.Find(id) != null;
        }
    }
}
