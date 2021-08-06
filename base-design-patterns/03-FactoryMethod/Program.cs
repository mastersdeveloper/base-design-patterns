using System;

namespace _03_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BebidaEmbriagante oBebida = Creador.CreadorBebida(Creador.CERVEZA);
            Console.WriteLine(oBebida.CuantoMeEmbriagaPorHora());
        }
    }
}
