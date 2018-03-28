using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterDetailApp.Models;

namespace MasterDetailApp.Services
{
    public class MockPersonaData : IPersonaDataStore<Persona>
    {
        private readonly List<Persona> _personas;
        public MockPersonaData()
        {
            _personas = new List<Persona>();
            var mockPersonas = new List<Persona>
            {
                new Persona{ Nombre ="Dave", Apellido = "First", Pais="Mexico" },
                new Persona{ Nombre = "Dave", Apellido = "Second",Pais="EUA" },
                new Persona{ Nombre = "Dave", Apellido = "Third", Pais="Colombia" },
                new Persona{ Nombre = "Dave", Apellido = "Fourth",Pais="Dinamarca" },
                new Persona{ Nombre = "Dave", Apellido = "Fifth", Pais="Argelia" },
                new Persona{ Nombre = "Dave", Apellido = "Sixth", Pais="España" },
            };

            foreach (var item in mockPersonas)
            {
                _personas.Add(item);
            }
        }

        public async Task<bool> AddPersonaAsync(Persona item)
        {
            _personas.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdatePersonaAsync(Persona item)
        {
            var pers = _personas.FirstOrDefault(arg => arg.NombreCompleto == item.NombreCompleto);
            _personas.Remove(pers);
            _personas.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeletePersonaAsync(Persona item)
        {

            var pers = _personas.FirstOrDefault(arg => arg.NombreCompleto == item.NombreCompleto);
            _personas.Remove(pers);

            return await Task.FromResult(true);
        }

        public async Task<Persona> GetItemAsync(string id)
        {
            return await Task.FromResult(_personas.FirstOrDefault(s => s.NombreCompleto == id));
        }

        public async Task<IEnumerable<Persona>> GetPersonaAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_personas);
        } 
    }
}
