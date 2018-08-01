using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Medistorial.DAL.EF;
using Medistorial.Models;
using Medistorial.Web.WebServiceAccess.Base;

namespace Medistorial.Web.Pages
{
    public class CreatePatientModel : PageModel
    {
        private readonly IWebApiCalls _webApiCalls;

        public CreatePatientModel(IWebApiCalls webApiCalls)
        {
            _webApiCalls = webApiCalls;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Patient Patient { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                await _webApiCalls.SavePatient(Patient);
            }
            catch (Exception ex)
            {

                return NotFound();
            }

            return RedirectToPage("./Index");
        }
    }
}