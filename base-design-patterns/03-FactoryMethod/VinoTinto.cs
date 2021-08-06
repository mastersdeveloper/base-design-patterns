using System;
using System.Collections.Generic;
using System.Text;

namespace _03_FactoryMethod
{
    public class VinoTinto : BebidaEmbriagante
    {
        public override int CuantoMeEmbriagaPorHora()
        {
            return 20;
        }
    }
}
