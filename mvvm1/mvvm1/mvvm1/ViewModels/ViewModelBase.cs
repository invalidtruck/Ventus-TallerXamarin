using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace mvvm1.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]
            string propertyName = null)
        {
            var handle = PropertyChanged;
            handle?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
