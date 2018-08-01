using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medistorial.DAL.Interfaces;
using Medistorial.Models;
using Microsoft.AspNetCore.Mvc;

namespace Medistorial.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : Controller
    {
        public PatientsController(IPatientRepo repo)
        {
            Repo = repo;
        }
        private IPatientRepo Repo { get; set; }
        [HttpGet]
        public IActionResult Get()
        {
            return Json(Repo.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = Repo.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Json(item);
        }
        [HttpPost]
        public IActionResult Save([FromBody] Patient patient)
        {
            if (patient == null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            if (patient.Id > 0)
            {
                //is an update
                Repo.Update(patient);
            }
            else
            {
                //is a new patient
                Repo.Add(patient);
            }

            return NoContent();
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return BadRequest();
            }
            Patient patientToRemove = Repo.Find(Id);
            if (patientToRemove == null)
            {
                return BadRequest();
            }
            Repo.Delete(patientToRemove);
            return NoContent();
        }
    }
}
