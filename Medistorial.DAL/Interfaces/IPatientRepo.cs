using Medistorial.DAL.Repos.Base;
using Medistorial.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medistorial.DAL.Interfaces
{
    public interface IPatientRepo : IRepo<Patient>
    {
        IEnumerable<Patient> GetAll();
        IEnumerable<Patient> GetRange(int skip, int take);
    }
}
