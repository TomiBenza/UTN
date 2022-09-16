using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _1._1_Carreras.AccesoDatos
{
    internal interface IDAO
    {
        DataTable Read(string SP);
        bool Create(string n,string t,List<DetalleCarrera> d);
        bool Update(Carrera c);
        bool Delete(Carrera c);
    }
}
