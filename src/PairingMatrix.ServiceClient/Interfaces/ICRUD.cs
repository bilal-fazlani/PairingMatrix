using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PairingMatrix.ServiceClient.Interfaces
{
    public interface ICRUD<T> where T: IModel
    {
        Task AddOrUpdateAsync(T model);
        
        Task DeletebyIdAsync(long id);

        Task<T> GetbyIdAsync(long id);

        Task<List<T>> GetPagedAsync(int startIndex, int pageSize);
    }
}