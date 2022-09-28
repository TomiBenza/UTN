using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class DetalleReceta
    {
        public int Cantidad { get; set; }
        public Ingrediente Ingrediente { get; set; }
        public DetalleReceta(Ingrediente ing,int cant)
        {
            Ingrediente = ing;
            Cantidad = cant;
        }
    }
}
