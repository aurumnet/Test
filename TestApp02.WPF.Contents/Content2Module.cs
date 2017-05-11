using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;
using TestApp02.WPF.Contents.Views;

namespace TestApp02.WPF.Contents
{
    public class Content2Module : IModule
    {
        [Dependency]
        public IUnityContainer Container { get; set; }
        [Dependency]
        public IRegionManager RegionManager { get; set; }

        public void Initialize()
        {
            this.Container.RegisterType<object, Content2MenuView>("Content2MenuView");
            this.Container.RegisterType<object, Content2View>("Content2View");
            this.RegionManager.RequestNavigate("MenuContentsRegion", "Content2MenuView");
        }
    }
}