using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Medistorial.DAL.EF;
using Medistorial.Models;
using Medistorial.Web.WebServiceAccess.Base;

namespace Medistorial.Web.Pages
{
    public class DeletePatientModel : PageModel
    {
        private readonly IWebApiCalls _webApiCalls;

        public DeletePatientModel(IWebApiCalls webApiCalls)
        {
            _webApiCalls = webApiCalls;
        }

        [BindProperty]
        public Patient Patient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? Id)
        {
            if (Id == null )
            {
                return NotFound();
            }
            Patient = await _webApiCalls.GetPatientAsync((int)Id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            await _webApiCalls.DeletePatient(Id);

            return RedirectToPage("./Index");
        }
    }
}
