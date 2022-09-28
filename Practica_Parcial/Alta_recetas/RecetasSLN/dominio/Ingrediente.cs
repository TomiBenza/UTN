﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Ingrediente
    {
        public int IngredienteId { get; set; }
        public string Nombre { get; set; }
        public string Unidad { get; set; }
        public Ingrediente(int id,string name,string unit)
        {
            IngredienteId = id;
            Nombre = name;
            Unidad = unit;
        }
    }
}
