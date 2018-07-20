using Medistorial.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medistorial.DAL.EF
{
    public class ApplicationDbContext : IdentityDbContext    
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
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
        public virtual DbSet<Medic> Medics { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
    }
}
