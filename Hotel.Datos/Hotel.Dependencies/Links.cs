using Hotel.Contratos;
using Hotel.Datos;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Dependencies
{
    public class Links : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IServicesRepository>().To<ServiceRepository>();
        }
    }
}
