﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace mvvm1
{
    class DelegateCommand : ICommand
    {
        private Action _execute;
        private Func<bool> _canExecute;

        public DelegateCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }


        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;
            return _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke();
        }

        public void OnCanExecuteChanged()
        {
            var handle = CanExecuteChanged;
            if (handle != null)
                handle(this, new EventArgs());

        }


        public event EventHandler CanExecuteChanged;
    }
}
