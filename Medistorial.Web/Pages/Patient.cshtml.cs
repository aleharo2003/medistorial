using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medistorial.Models;
using Medistorial.Web.WebServiceAccess.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Medistorial.Web.Pages
{
    public class PatientModel : PageModel
    {
        public Patient Patient { get; set; }
        private readonly IWebApiCalls _webApiCalls;
        public PatientModel(IWebApiCalls webApiCalls)
        {
            _webApiCalls = webApiCalls;
        }
        
        public async Task<IActionResult> OnGetAsync(int Id)
        {
            Patient = await _webApiCalls.GetPatientAsync(Id);
            return Page();
        }
    }
}