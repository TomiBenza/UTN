using _1._1_Carreras.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Carreras.Servicios
{
    abstract internal class AbstractServiceFactory
    {
        public abstract ICarrerasService CrearCarrerasService();
    }
}
