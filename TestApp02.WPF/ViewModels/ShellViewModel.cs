﻿using Prism.Mvvm;

namespace TestApp02.WPF.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        private string _title = "Prism Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ShellViewModel()
        {

        }
    }
}
