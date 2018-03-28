using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterDetailApp.Models;
using MasterDetailApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonaPage : ContentPage
    {
        public PersonaPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new PersonasViewModel();
        }
     
        PersonasViewModel viewModel;



        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (!(args.SelectedItem is Persona item))
                return;

            await Navigation.PushAsync(new PersonaDetailPage(new PersonaDetailViewModel(item)));

            // Manually deselect item.
            PersonasListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewPersonaPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Personas.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}