using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2._1_Pilas.Dominio
{
    internal class Pila
    {
        public int nroPila { get; set; }
        public Pila(int nro)
        {
            nroPila = nro;
        }
        public override string ToString()
        {
            return "Pila N° " + nroPila;
        }
    }
}
