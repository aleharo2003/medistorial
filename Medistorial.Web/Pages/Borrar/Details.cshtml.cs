using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Medistorial.DAL.EF;
using Medistorial.Models;

namespace Medistorial.Web.Pages.Borrar
{
    public class DetailsModel : PageModel
    {
        private readonly Medistorial.DAL.EF.ApplicationDbContext _context;

        public DetailsModel(Medistorial.DAL.EF.ApplicationDbContext context)
        {
            _context = context;
        }

        public Medic Medic { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medic = await _context.Medics.FirstOrDefaultAsync(m => m.Id == id);

            if (Medic == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
