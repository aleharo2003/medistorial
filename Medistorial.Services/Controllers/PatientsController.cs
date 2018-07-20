using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medistorial.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Medistorial.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : Controller
    {
        public PatientsController(IPatientRepo repo)
        {
            Repo = repo;
        }

        public IActionResult Index()
        {
            return View();
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
    }
}