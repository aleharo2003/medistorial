using Medistorial.Models;
using Medistorial.Web.Configuration;
using Medistorial.Web.WebServiceAccess.Base;
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
            return await GetItemListAsync<Patient>(PatientBaseUri);
        }
    }
}
