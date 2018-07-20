using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;

namespace Medistorial.Web.Pages
{
    public class IndexModel : PageModel
    {
        SignInManager<IdentityUser> SignInManager;
        UserManager<IdentityUser> UserManager;
        public void OnGet()
        {
            if (SignInManager.IsSignedIn(User))
            {

            }
            else
            {
                returnUrl = returnUrl ?? Url.Content("~/");
            }
        }
    }
}
