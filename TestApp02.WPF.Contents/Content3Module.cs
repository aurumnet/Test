using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;
using TestApp02.WPF.Contents.Views;

namespace TestApp02.WPF.Contents
{
    public class Content3Module : IModule
    {
        [Dependency]
        public IUnityContainer Container { get; set; }
        [Dependency]
        public IRegionManager RegionManager { get; set; }

        public void Initialize()
        {
            this.Container.RegisterType<object, Content3MenuView>("Content3MenuView");
            this.Container.RegisterType<object, Content3View>("Content3View");
            this.RegionManager.RequestNavigate("MenuContentsRegion", "Content3MenuView");
        }
    }
}