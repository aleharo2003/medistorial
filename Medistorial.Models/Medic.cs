using Medistorial.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medistorial.Models
{
    public class Medic : Person
    {
        public List<Contact> Contacts { get; set; }
        public List<Speciality> Specialities { get; set; }
    }
}
