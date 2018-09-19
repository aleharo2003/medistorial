using Medistorial.Services.Specialities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medistorial.Services.Medics.Dtos
{
    public class GetAllMedicsOutputDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Description { get; set; }
        public int SpecialityId { get; set; }
        public string SpecialityName { get; set; }
        //public SpecialityDto Speciality { get; set; }
    }
}
