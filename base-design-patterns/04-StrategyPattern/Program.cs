using System;

namespace _04_StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EstrategiasDelBorrachoContexto oBorrarcho = new EstrategiasDelBorrachoContexto();
            oBorrarcho.Conquistar(EstrategiasDelBorrachoContexto.Comportamiento.HacerOjitos);
            oBorrarcho.Conquistar(EstrategiasDelBorrachoContexto.Comportamiento.InvitarCerveza);
        }
    }
}
