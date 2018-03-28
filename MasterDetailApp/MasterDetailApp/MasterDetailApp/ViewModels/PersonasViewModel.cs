using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using MasterDetailApp.Models;
using MasterDetailApp.Views;

namespace MasterDetailApp.ViewModels
{
    public class PersonasViewModel : BaseViewModel
    {
        public ObservableCollection<MasterDetailApp.Models.Persona> Personas { get; set; }
        public Command LoadItemsCommand { get; set; }

        public PersonasViewModel()
        {
            Title = "Personas";
            Personas = new ObservableCollection<Persona>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewPersonaPage, Persona>(this, "AddPersona", async (obj, item) =>
            {
                var _item = item as Persona;
                Personas.Add(_item);
                await PersonaDataStore.AddPersonaAsync(_item);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Personas.Clear();
                var items = await PersonaDataStore.GetPersonaAsync(true);
                foreach (var item in items)
                {
                    Personas.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}