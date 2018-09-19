using Medistorial.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Medistorial.Core
{
    [Table("mdhMedic")]
    public class Medic : EntityBase
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        [Required]
        [StringLength(MaxTitleLength)]
        public string Name { get; set; }
        [StringLength(MaxTitleLength)]
        public string LastName { get; set; }
        [StringLength(MaxTitleLength)]
        public string Address { get; set; }
        [StringLength(MaxTitleLength)]
        public string Phone { get; set; }
        [StringLength(MaxTitleLength)]
        public string Mobile { get; set; }
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }
        [ForeignKey(nameof(SpecialityId))]
        public Speciality Speciality { get; set; }
        public int SpecialityId { get; set; }

        public Medic(string name, string lastName, string address = "", string phone = "", string mobile = "", int specialityId = 0)
        {
            Name = name;
            LastName = lastName;
            Address = address;
            Phone = phone;
            Mobile = mobile;
            SpecialityId = specialityId;
        }
        public Medic()
        {

        }
    }
}
