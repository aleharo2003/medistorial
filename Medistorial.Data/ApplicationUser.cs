using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Medistorial.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public virtual string FirstName { get; set; }
        [PersonalData]
        public virtual string LastName { get; set; }
        [PersonalData]
        public virtual string Address { get; set; }
        [PersonalData]
        public virtual string Phone { get; set; }
        [PersonalData]
        public virtual string Mobile { get; set; }
        [PersonalData]
        public virtual string Description { get; set; }
        
    
    }
}
