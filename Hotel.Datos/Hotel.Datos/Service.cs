using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Entities;
using Hotel.Contratos;

namespace Hotel.Datos
{
    public class Service : GenericRepository<HotelEntities, SERVICES>, IServicesRepository
    {

    }
}
