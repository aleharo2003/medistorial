using Medistorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medistorial.DAL.EF
{
    public class MedistorialContext : DbContext
    {
        public MedistorialContext()
        {

        }
        public MedistorialContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
            @"Server=Matrix;Database=medistorial;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }
        public virtual DbSet<Patient> Patients { get; set; }
    }
}

