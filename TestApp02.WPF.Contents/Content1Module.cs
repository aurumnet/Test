using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;
using TestApp02.WPF.Contents.Views;

namespace TestApp02.WPF.Contents
{
    public class Content1Module : IModule
    {
        [Dependency]
        public IUnityContainer Container { get; set; }
        [Dependency]
        public IRegionManager RegionManager { get; set; }

        public void Initialize()
        {
            this.Container.RegisterType<object, Content1MenuView>("Content1MenuView");
            this.Container.RegisterType<object, Content1View>("Content1View");

            this.RegionManager.RequestNavigate("MenuContentsRegion", "Content1MenuView");
        }
    }
}