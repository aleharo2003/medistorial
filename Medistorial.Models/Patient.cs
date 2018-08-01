using Medistorial.Models.Base;
using Medistorial.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Medistorial.Models
{
    public class Patient : Person
    {
        [Required]
        [DataType(DataType.Date), Display(Name = "Fecha de Nacimiento")]
        public DateTime BirthDate { get; set; }
        //[DataType(DataType.Text), MaxLength(3), Display(Name = "Tipo de Sangre")]
        public BloodType BloodType { get; set; }
        //[Required]
        //[DataType(DataType.Text), MaxLength(50), Display(Name = "Genero")]
        //public Genre Genre { get; set; }
        [DataType(DataType.Text), MaxLength(8), Display(Name = "D.N.I.")]
        public string DNI { get; set; }
        [DataType(DataType.Text), MaxLength(50), Display(Name = "Obra Social")]
        public string OS { get; set; }
        [DataType(DataType.Text), MaxLength(50), Display(Name = "Nº de Asociado a Obra Social")]
        public string OSUserCode { get; set; }
        public List<Contact> Contacts { get; set; }

    }    
}
