using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Medistorial.Web.WebServiceAccess.Base;
using Medistorial.Models;

namespace Medistorial.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IWebApiCalls _webApiCalls;

        public IndexModel(IWebApiCalls webApiCalls)
        {
            _webApiCalls = webApiCalls;
        }

        public IList<Patient> Patients { get; set; }
        
        public async Task<IActionResult> OnGetAsync()
        {
            Patients = await _webApiCalls.GetPatientsAsync();
            return Page();
        }
    }
}
