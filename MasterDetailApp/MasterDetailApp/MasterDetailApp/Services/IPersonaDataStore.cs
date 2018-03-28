using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailApp.Services
{
    public interface IPersonaDataStore<T>
    {
        Task<bool> AddPersonaAsync(T item);
        Task<bool> UpdatePersonaAsync(T item);
        Task<bool> DeletePersonaAsync(T item);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetPersonaAsync(bool forceRefresh = false);
    }
}

