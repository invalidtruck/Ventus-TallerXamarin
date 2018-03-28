using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace mvvm1.ViewModels
{

    public class MainViewModel : ViewModelBase
    {
        private string _name;
        private DelegateCommand _myCommand;

        void SetDefaultDataCommand()
        {
            this.Nombre = "David";
            this.Apellido = "Silva";
            this.Email = "dsilva@ventus-tech.com";
            //OnPropertyChanged(nameof(Nombre));
            //OnPropertyChanged(nameof(Apellido));
            //OnPropertyChanged(nameof(Email));
        }

        public ICommand MyCommand
        {
            get
            {
                return _myCommand =
                    _myCommand ??
                    new DelegateCommand(SetDefaultDataCommand);
            }
        }




        public MainViewModel()
        {
            Nombre = "";
        }

        public string Nombre
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DatosCompletos));
            }
        }
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set
            {
                _apellido = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DatosCompletos));
            }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DatosCompletos));
            }
        }

        public string DatosCompletos => $"{Nombre} {Apellido} {Environment.NewLine} {Email}";

    }
}
