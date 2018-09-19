using Medistorial.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Medistorial.Core
{
    [Table("mdhSpeciality")]
    public class Speciality : EntityBase
    {
        public const int MaxNameLength = 32;

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }
        public Speciality(string name)
        {
            Name = name;
        }
        public Speciality()
        {            
        }
    }
}
