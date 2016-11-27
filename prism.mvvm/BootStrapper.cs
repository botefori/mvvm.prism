using prism.mvvm.Views;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace prism.mvvm
{
    public class BootStrapper:UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            //return Container.Resolve(;
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType(typeof(object), typeof(viewA), "viewA", null);
            Container.RegisterType(typeof(object), typeof(viewA), "viewB", null);
        }
    }
}
