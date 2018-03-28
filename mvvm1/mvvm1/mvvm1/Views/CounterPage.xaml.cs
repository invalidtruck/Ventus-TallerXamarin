using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvvm1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvvm1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CounterPage : ContentPage
	{
		public CounterPage ()
		{
			InitializeComponent ();
		    BindingContext = new CounterViewModel();
		}
	}
}