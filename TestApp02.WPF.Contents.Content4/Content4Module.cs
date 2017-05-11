using Prism.Modularity;
using Prism.Regions;
using System;

namespace TestApp02.WPF.Contents.Content4
{
    public class Content4Module : IModule
    {
        IRegionManager _regionManager;

        public Content4Module(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}