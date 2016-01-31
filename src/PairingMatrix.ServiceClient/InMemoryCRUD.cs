using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PairingMatrix.Service.Interfaces;
using PairingMatrix.ServiceClient.Interfaces;

namespace PairingMatrix.ServiceClient
{
    public class InMemoryCRUD<T> : ICRUD<T> where T:IModel
    {
        private readonly ConcurrentDictionary<long, T> _data = new ConcurrentDictionary<long,T>();
        private long _identity = 0;

        public async Task AddOrUpdateAsync(T model)
        {
            if (model.Id != 0) //update
            {
                _data[model.Id] = model;
            }
            else // add new model
            {
                model.Id = ++_identity;
                _data.TryAdd(model.Id, model);
            }
        }

        public async Task DeletebyIdAsync(long id)
        {
            T itemToDelete;
            _data.TryRemove(id, out itemToDelete);
        }

        public async Task<T> GetbyIdAsync(long id)
        {
            T item;
            _data.TryGetValue(id, out item);
            return item;
        }

        public async Task<List<T>> GetPagedAsync(int startIndex, int pageSize)
        {
            return _data.Skip(startIndex)
                .Take(pageSize)
                .Select(x=>x.Value)
                .ToList();
        }
    }
}