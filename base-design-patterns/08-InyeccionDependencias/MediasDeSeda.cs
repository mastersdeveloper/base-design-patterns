using System;
using System.Collections.Generic;
using System.Text;

namespace _08_InyeccionDependencias
{
    public class MediasDeSeda : IBebida
    {
        public void Preparar()
        {
            Console.WriteLine("Preparando la bebida Media de Seda");
        }
    }
}
