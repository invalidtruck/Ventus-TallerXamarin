using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace mvvm1.ViewModels
{
    public class CounterViewModel : ViewModelBase
    {
        private ICommand _micomando;

        public CounterViewModel()
        {

        }

        private int _contar;

        public string Contar
        {
            get { return $"has presionado {_contar} veces"; } 
        }
        public ICommand MyCommand
        {
            get { return _micomando = _micomando ?? new DelegateCommand(CounterCommandEx); }
        }
        void CounterCommandEx()
        {
            _contar++;
            OnPropertyChanged(nameof(Contar));
        }

    }
}
