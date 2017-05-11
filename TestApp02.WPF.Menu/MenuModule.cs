using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;
using TestApp02.WPF.Menu.Views;

namespace TestApp02.WPF.Menu
{
    public class MenuModule : IModule
    {
        [Dependency]
        public IUnityContainer Container { get; set; }
        [Dependency]
        public IRegionManager RegionManager { get; set; }

        public void Initialize()
        {
            this.Container.RegisterType<object, MenuView>(nameof(MenuView));

            this.RegionManager.RequestNavigate("MenuRegion", nameof(MenuView));
        }
    }
}