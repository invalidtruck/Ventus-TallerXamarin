using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterDetailApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewPersonaPage : ContentPage
	{
        public Persona Persona { get; set; }

		public NewPersonaPage ()
		{
			InitializeComponent ();
		    Persona = new Persona
		    {
		        Nombre = "",
		        Apellido = "",
                Pais = ""
		    };
            BindingContext = this;
        }

	    async void Save_Clicked(object sender, EventArgs e)
	    {
	        MessagingCenter.Send(this,"AddPersona", Persona);
	        await Navigation.PopModalAsync();

        }
    }
}