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
    public partial class PersonaDetailPage : ContentPage
    {


        PersonaDetailViewModel _viewModel;

        public PersonaDetailPage(PersonaDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this._viewModel = viewModel;
        }

        public PersonaDetailPage()
        {
            InitializeComponent();

            var item = new Persona
            {
                Nombre = "",
                Apellido = "",
                Pais = ""
            };

            _viewModel = new PersonaDetailViewModel(item);
            BindingContext = _viewModel;
        }
    }
}