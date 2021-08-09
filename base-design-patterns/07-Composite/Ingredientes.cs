using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Composite
{
    public class Ingredientes : Component
    {
        public int Cantidad { get; set; }
        public string Unidad { get; set; }

        public Ingredientes(string Nombre, decimal Costo, int Cantidad, string Unidad) : base(Nombre, Costo)
        {
            this.Cantidad = Cantidad;
            this.Unidad = Unidad;
        }
    }
}
