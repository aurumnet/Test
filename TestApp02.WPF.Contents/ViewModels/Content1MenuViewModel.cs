using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Regions;
using Microsoft.Practices.Unity;
using System.Windows.Input;

namespace TestApp02.WPF.Contents.ViewModels
{
    public class Content1MenuViewModel : BindableBase
    {
        [Dependency]
        public IRegionManager RegionManager { get; set; }

        private ICommand content1Command;
        public ICommand Content1Command
        { get { return this.content1Command ?? (this.content1Command = new DelegateCommand(Content1NavigationExecute)); } }

        public void Content1NavigationExecute()
        {
            RegionManager.RequestNavigate("ContentRegion", "Content1View");
        }



        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }

        public Content1MenuViewModel()
        {

        }
    }
    
}
