using Medistorial.Core;
using Medistorial.Data.Repositories.Base;
using Medistorial.Services.Medics.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Medistorial.Services.Medics
{
    public interface IMedicAppService : IRepository<Medic>
    {
        //Task<List<GetAllMedicsOutputDto>> GetAll(GetAllMedicsInputDto input);
        //Task Save(SaveMedicInputDto input);
        //Task Delete(DeleteMedicInputDto input);        
        //Task<GetMedicOutputDto> GetMedic(GetMedicInputDto input);
    }
}
