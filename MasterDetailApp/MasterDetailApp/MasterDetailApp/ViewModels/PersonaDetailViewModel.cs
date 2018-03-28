using System;

using MasterDetailApp.Models;

namespace MasterDetailApp.ViewModels
{
    public class PersonaDetailViewModel : BaseViewModel
    {
        public Persona Persona { get; set; }
        public PersonaDetailViewModel(Persona item = null)
        {
            Persona = item;
            Title = item?.NombreCompleto;
        }
    }
}
