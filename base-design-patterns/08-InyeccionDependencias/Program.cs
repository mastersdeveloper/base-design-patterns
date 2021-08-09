using System;

namespace _08_InyeccionDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            IBebida piñaColada = new PiñaColada();
            IBebida mediaDeSeda = new MediasDeSeda();

            Cantinero cantinero = new Cantinero(piñaColada);
            cantinero.Preparar();
        }
    }
}
