using System.Collections.Generic;
using System.Threading.Tasks;
using PairingMatrix.ServiceClient.Interfaces;

namespace PairingMatrix.ServiceClient
{
    public class RealCRUD<T> : ICRUD<T> where T: IModel
    {
        public Task AddOrUpdateAsync(T model)
        {
            return null;
        }

        public Task DeletebyIdAsync(long id)
        {
            return null;
        }

        public Task<T> GetbyIdAsync(long id)
        {
            return null;
        }

        public Task<List<T>> GetPagedAsync(int startIndex, int pageSize)
        {
            return null;
        }
    }
}
