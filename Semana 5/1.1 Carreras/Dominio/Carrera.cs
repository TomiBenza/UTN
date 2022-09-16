using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _1._1_Carreras.AccesoDatos;

namespace _1._1_Carreras
{
    internal class Carrera
    {
        private string nombre;
        private string titulo;
        public int IdCarrera { get; set; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public List<DetalleCarrera> Detalles { get; set; }
        public int Estado { get; set; }
        public Carrera()
        {
            Detalles=new List<DetalleCarrera>();
        }
        public Carrera(string nombre,string titulo,List<DetalleCarrera> detalle,int estado)
        {
            Nombre = nombre;
            Titulo = titulo;
            Detalles= detalle;
            estado = 1;
        }
        public override string ToString()
        {
            return Nombre;
        }
        public void AgregarDetalle(DetalleCarrera detalle)
        {
            Detalles.Add(detalle);
        }
        public void QuitarDetalle(int index)
        {
            Detalles.RemoveAt(index);
        }
        public bool AgregarCarrera()
        {
            bool result = true;
            try
            {
                HelperDAO.GetInstance().Create(this.Nombre, this.Titulo, this.Detalles);
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

    }
}
