using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Medistorial.DAL.EF;
using Medistorial.Models;

namespace Medistorial.Web.Pages.Borrar2
{
    public class IndexModel : PageModel
    {
        private readonly Medistorial.DAL.EF.ApplicationDbContext _context;

        public IndexModel(Medistorial.DAL.EF.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Medic> Medic { get;set; }

        public async Task OnGetAsync()
        {
            Medic = await _context.Medics.ToListAsync();
        }
    }
}
