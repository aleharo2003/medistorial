using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Medistorial.Models.Base
{
    public abstract class Person : EntityBase
    {
        [Required]
        [DataType(DataType.Text), MaxLength(50), Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Text), MaxLength(50), Display(Name = "Apellido")]
        public string LastName { get; set; }

    }
}
