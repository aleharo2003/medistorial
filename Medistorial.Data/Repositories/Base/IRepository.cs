using Medistorial.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Medistorial.Data.Repositories.Base
{
    public interface IRepository<T> where T : EntityBase
    {
        int Count { get; }
        bool HasChanges { get; }
        T Find(int? id);
        //Task<T> FindAsync(int? id);
        T GetFirst();
        //Task<T> GetFirstAsync();
        IEnumerable<T> GetAll();
        //Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> GetRange(int skip, int take);
        int Add(T entity, bool persist = true);
        int AddRange(IEnumerable<T> entities, bool persist = true);
        int Update(T entity, bool persist = true);
        int UpdateRange(IEnumerable<T> entities, bool persist = true);
        int Delete(T entity, bool persist = true);
        int DeleteRange(IEnumerable<T> entities, bool persist = true);
        //int Delete(int id, byte[] timeStamp, bool persist = true);
        int SaveChanges();
    }
}
