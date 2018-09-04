using Hotel.Contratos;
using Hotel.Entities;
using System;
using System.Collections.Generic;

namespace Hotel.Bussines
{
    public class ManagementServices : ManagementBase<IServicesRepository, SERVICES>, IManagementServices
    {
        public ManagementServices(IServicesRepository repository) : base(repository)
        {
        }

        public override IEnumerable<SERVICES> ObtenerPor()
        {
            throw new NotImplementedException();
        }
    }
}
