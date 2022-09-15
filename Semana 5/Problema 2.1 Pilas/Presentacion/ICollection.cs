using Problema_2._1_Pilas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2._1_Pilas.Presentacion
{
    internal interface ICollection
    {
        bool estaVacia();
        Pila extraer();
        Pila primero();
        bool añadir(Pila p);
    }
}
