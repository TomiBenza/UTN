using Problema_2._2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2._2.Servicios
{
    internal interface ICollection
    {
        bool añadir(List<Producto> lst,Producto p);
        Producto primero(List<Producto> lst);
        Producto extraer(List<Producto> lst);
        bool estaVacia(List<Producto> lst);
    }
}
