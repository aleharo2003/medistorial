using Medistorial.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Medistorial.Data.EntityFrameworkCore
{
    public class MedistorialDbContext : IdentityDbContext<ApplicationUser>
    {
        public MedistorialDbContext(DbContextOptions<MedistorialDbContext> options)
            : base(options)
        {

        }
        public MedistorialDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //.AddJsonFile("appsettings.json")
            //.Build();
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
            @"Server=Matrix;Database=medistorialMVC;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }
        //public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Medic> Medics { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }        
    }
}
