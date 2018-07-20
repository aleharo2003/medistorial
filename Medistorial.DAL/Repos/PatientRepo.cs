using Medistorial.DAL.EF;
using Medistorial.DAL.Interfaces;
using Medistorial.DAL.Repos.Base;
using Medistorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Medistorial.DAL.Repos
{
    public class PatientRepo : RepoBase<Patient>, IPatientRepo
    {
        public PatientRepo(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public PatientRepo()
        {

        }
        public override IEnumerable<Patient> GetAll()
            => Table.OrderBy(x => x.LastName);

        public override IEnumerable<Patient> GetRange(int skip, int take)
            => GetRange(Table.OrderBy(x => x.LastName), skip, take);

    }
}
