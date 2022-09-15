using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2._2.Dominio
{
    internal class Producto
    {
        public int Nro { get; set; }
        public Producto(int nro)
        {
            Nro = nro;
        }
        public override string ToString()
        {
            return "Producto nro: " + Nro;
        }
    }
}
