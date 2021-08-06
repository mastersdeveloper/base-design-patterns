using System;
using System.Collections.Generic;
using System.Text;

namespace _04_StrategyPattern
{
    class EstrategiaOjitos : IBorracho
    {
        public void Conquistar()
        {
            Console.WriteLine("Le hago ojitos a la muchacha");
        }
    }
}
