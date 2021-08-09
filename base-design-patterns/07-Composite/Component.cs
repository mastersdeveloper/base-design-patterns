﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Composite
{
    public abstract class Component
    {
        public string Nombre { get; set; }
        public decimal Costo { get; set; }

        public Component(string Nombre, decimal Costo)
        {
            this.Nombre = Nombre;
            this.Costo = Costo;
        }
    }
}
