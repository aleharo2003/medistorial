using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medistorial.Models;
using Medistorial.Web.WebServiceAccess.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Medistorial.Web.Pages.Users
{
    public class IndexModel : PageModel
    {
        public Patient Patient { get; set; }
        private readonly IWebApiCalls _webApiCalls;
        public IndexModel(IWebApiCalls webApiCalls)
        {
            _webApiCalls = webApiCalls;
        }


        public async Task OnGetAsync(int Id)
        {
            Patient = await _webApiCalls.GetPatientAsync((int)Id);
        }
        public async Task OnPostAsync()
        {

            var taka = await _webApiCalls.GetPatientsAsync();
        }

    }
}