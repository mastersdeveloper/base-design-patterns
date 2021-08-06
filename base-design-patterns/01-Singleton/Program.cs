using System;

namespace _01_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.mensaje);

            Singleton.Instance.mensaje = "Hola Martes";

            Console.WriteLine(Singleton.Instance.mensaje);
        }
    }
}
