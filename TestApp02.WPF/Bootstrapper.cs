using Microsoft.Practices.Unity;
using Prism.Unity;
using TestApp02.WPF.Views;
using System.Windows;
using Prism.Modularity;
using TestApp02.WPF.Menu;
using TestApp02.WPF.Contents;

namespace TestApp02.WPF
{
    class Bootstrapper : UnityBootstrapper
    {
            protected override void ConfigureModuleCatalog()
            {
                base.ConfigureModuleCatalog();

                var catalog = (ModuleCatalog)this.ModuleCatalog;
                catalog.AddModule(typeof(MenuModule));
                catalog.AddModule(typeof(Content1Module));
                catalog.AddModule(typeof(Content2Module));
                catalog.AddModule(typeof(Content3Module));
            }

            protected override DependencyObject CreateShell()
            {
                return Container.Resolve<Shell>();
            }

            protected override void InitializeShell()
            {
                ((Window)this.Shell).Show();
            }
        }
}
