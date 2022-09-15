using Problema_2._1_Pilas.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2._1_Pilas.Dominio
{
    internal class PilaInt : ICollection
    {
        public Pila[] aPila;
        public PilaInt(int cant)
        {
            aPila = new Pila[cant];
        }
        public bool estaVacia()
        {
            bool result=true;
            for(int i = 0; i < aPila.Length; i++)
            {
                if(aPila[i] != null)
                {
                    result=false;
                }
            }
            return result;
        }
        public Pila extraer()
        {
            Pila p=null;
            for(int i = 0; i < aPila.Length; i++)
            {
                if (aPila[i] != null)
                {
                    p = aPila[i];
                    aPila[i] = null;
                    break;
                }
            }
            return p;
        }
        public Pila primero()
        {
            Pila p = null;
            for(int i = 0; i < aPila.Length; i++)
            {
                if (aPila[i] != null)
                {
                    p= aPila[i];
                    break;
                }
            }
            return p;

        }
        public bool añadir(Pila p)
        {
            bool result = false;
            for (int i = 0; i < aPila.Length; i++)
            {
                if (aPila[i] == null)
                {
                    aPila[i]=p;
                    result = true;
                    break;
                }
            }
            return result;
        }
        public int Libre()
        {
            int libre = -1;
            for(int i = 0; i < aPila.Length; i++)
            {
                if(aPila[i] == null)
                {
                    libre = i++;
                    break;
                }
            }
            return libre;
        }
    }
}
