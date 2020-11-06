using Autofac;
using Healthy.ApplicationObjects;
using Healthy.IMC.ViewModels;
using Healthy.News.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Healthy.Mobile
{
    public class Setup : AppSetup
    {
        protected override void RegisterDependencies(ContainerBuilder cb)
        {
            base.RegisterDependencies(cb);

            cb.RegisterType<IMCMainViewModel>().SingleInstance();
            cb.RegisterType<NewsMainViewModel>().SingleInstance();
        }
    }
}
