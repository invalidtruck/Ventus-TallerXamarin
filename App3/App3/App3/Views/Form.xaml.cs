using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3.Views
{
    public partial class Form : ContentPage
    {
        public Form()
        {
            InitializeComponent();
            //lbl.Text = "Hola desde el codigo!";
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var alertmsg = $"Hola soy {txtNombre.Text} {txtLastName.Text} vivo en {txtCountry.Text}";
            DisplayAlert("Curso Xamarin", alertmsg, "OK");
        }
    }
}
