using Problema_2._2.Servicios;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2._2.Dominio
{
    internal class gestorProducto : ICollection
    {
        private List<Producto> lProducto;
        public bool estaVacia(List<Producto> lst)
        {
            bool result = false;
            if(lst.Count == 0)
            {
                result = true;
            }
            return result;
        }
        public Producto extraer(List<Producto> lst)
        {
            Producto result = null;
            for(int i = 0; i < lst.Count; i++)
            {
                if(lst[i] != null)
                {
                    result=lst[i];
                    lst.Remove(lst[i]);
                    break;
                }
            }
            return result;
        }
        public Producto primero(List<Producto> lst)
        {
            Producto p=null;
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] != null)
                {
                    p=lst[i];
                    break;
                }
            }
            return p;
        }
        public bool añadir(List<Producto> lst,Producto p)
        {
            bool result=false;
            try
            {
                lst.Add(p);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
        public int Contar(List<Producto> lst)
        {
            int count = 0;
            foreach (Producto p in lst)
            {
                count++;
            }
            return count;
        }
    }
}
