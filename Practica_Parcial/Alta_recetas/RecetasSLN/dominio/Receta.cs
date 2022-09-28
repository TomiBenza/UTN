using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Receta
    {
       
        public string Nombre { get; set; }
        public int TipoReceta { get; set; }
        public string Cheff { get; set; }
        public List<DetalleReceta> Detalle { get; set; }

        public Receta(string name,int type,string cheff,List<DetalleReceta> det)
        {
            
            Nombre=name;
            TipoReceta=type;
            Cheff=cheff;
            Detalle=det;
        }
        public Receta()
        {
            Detalle = new List<DetalleReceta>();
        }
        public void AgregarDetalle(DetalleReceta d)
        {
            this.Detalle.Add(d);
        }
        public void QuitarDetalle(int index)
        {
            Detalle.RemoveAt(index);
        }

    }
}
