using Medistorial.Core;
using Medistorial.Core.Base;
using Medistorial.Data.Repositories.Base;
using Medistorial.Services.Specialities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Medistorial.Services.Specialities
{
    public interface ISpecialityAppService : IRepository<Speciality>
    {
        //Task<List<GetAllSpecialityOutputDto>> GetAllAsync(GetAllSpecialityInputDto input);
        //Task Save(SaveSpecialityInputDto input);
        //Task DeleteAsync(DeleteSpecialityInputDto input);
        //Task<GetSpecialityOutputDto> GetSpeciality(GetSpecialityInputDto input);
    }
}
