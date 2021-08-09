using System;

namespace _07_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingredientes oIngredientes1 = new Ingredientes("Harina", 100, 200, "gramos");
            Ingredientes oIngredientes2 = new Ingredientes("Leche", 20, 1, "litros");
            Ingredientes oIngredientes3 = new Ingredientes("Huevos", 200, 1, "kilos");

            PastelComposite oPastel = new PastelComposite("Pastel de leche");
            oPastel.Add(oIngredientes1);
            oPastel.Add(oIngredientes2);
            oPastel.Add(oIngredientes3);

            Console.WriteLine(oPastel.Costo);

            Ingredientes oIngredientes4 = new Ingredientes("Chocolate", 200, 1, "litros");

            PastelComposite oPastelChocolateYLeche = new PastelComposite("Pastel Compuesto");

            oPastelChocolateYLeche.Add(oIngredientes4);
            oPastelChocolateYLeche.Add(oPastel);

            Console.WriteLine(oPastelChocolateYLeche.CostoTotal);
        }
    }
}
