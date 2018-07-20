using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Medistorial.DAL.EF;
using Medistorial.Models;

namespace Medistorial.Web.Pages.Borrar2
{
    public class EditModel : PageModel
    {
        private readonly Medistorial.DAL.EF.ApplicationDbContext _context;

        public EditModel(Medistorial.DAL.EF.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Medic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicExists(Medic.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MedicExists(int id)
        {
            return _context.Medics.Any(e => e.Id == id);
        }
    }
}
