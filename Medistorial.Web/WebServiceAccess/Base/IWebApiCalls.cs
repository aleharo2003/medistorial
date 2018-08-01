using Medistorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medistorial.Web.WebServiceAccess.Base
{
    public interface IWebApiCalls
    {
        //PatientsController
        Task<IList<Patient>> GetPatientsAsync();
        Task<Patient> GetPatientAsync(int patientId);
        Task<string> SavePatient(Patient patient);
        Task DeletePatient(int? Id);
    }
}
