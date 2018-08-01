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
using Medistorial.Web.WebServiceAccess.Base;

namespace Medistorial.Web.Pages
{
    public class EditPatientModel : PageModel
    {
        private readonly IWebApiCalls _webApiCalls;

        public EditPatientModel(IWebApiCalls webApiCalls)
        {
            _webApiCalls = webApiCalls;
        }

        [BindProperty]
        public Patient Patient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Patient = await _webApiCalls.GetPatientAsync((int)id);

            if (Patient == null)
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

        //private bool PatientExists(int id)
        //{
        //    return _context.Patients.Any(e => e.Id == id);
        //}
    }
}
