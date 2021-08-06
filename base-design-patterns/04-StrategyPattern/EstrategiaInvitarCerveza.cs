using System;
using System.Collections.Generic;
using System.Text;

namespace _04_StrategyPattern
{
    class EstrategiaInvitarCerveza : IBorracho
    {
        public void Conquistar()
        {
            Console.WriteLine("Le invito una cerveza");
        }
    }
}
