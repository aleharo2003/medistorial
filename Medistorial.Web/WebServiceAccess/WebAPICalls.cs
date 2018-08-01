using Medistorial.Models;
using Medistorial.Web.Configuration;
using Medistorial.Web.WebServiceAccess.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medistorial.Web.WebServiceAccess
{
    public class WebApiCalls : WebApiCallsBase, IWebApiCalls
    {
        public WebApiCalls(IWebServiceLocator settings) : base(settings)
        {
        }
        //Patients
        public async Task<IList<Patient>> GetPatientsAsync()
        {
            //https://localhost:5001/api/Patients/
            return await GetItemListAsync<Patient>(PatientBaseUri);
        }
        public async Task<Patient> GetPatientAsync(int Id)
        {
            //https://localhost:5001/api/Patients/4
            return await GetItemAsync<Patient>($"{PatientBaseUri}{Id}"); 
        }

        public async Task<string> SavePatient(Patient patient)
        {
            //https://localhost:5001/api/Patients/
            var json = JsonConvert.SerializeObject(patient);
            var uri = $"{PatientBaseUri}";
            var result = Convert.ToString(await SubmitPostRequestAsync(uri, json));
            return result;
        }
        public async Task DeletePatient(int? Id)
        {
            //https://localhost:5001/api/Patients/4
            var uri = $"{PatientBaseUri}{Id}";
            await SubmitDeleteRequestAsync(uri);
        }       
    }
}
