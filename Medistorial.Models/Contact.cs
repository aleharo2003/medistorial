using Medistorial.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medistorial.Models
{
    public class Contact : EntityBase
    {
        public string Address { get; set; }
        public string Number { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }
        public string ZIPCode { get; set; }
    }
}
