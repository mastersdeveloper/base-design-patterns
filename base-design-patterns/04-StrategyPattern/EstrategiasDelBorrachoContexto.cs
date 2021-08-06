using System;
using System.Collections.Generic;
using System.Text;

namespace _04_StrategyPattern
{
    class EstrategiasDelBorrachoContexto
    {
        private IBorracho oBorracho;

        public EstrategiasDelBorrachoContexto()
        {
            //por defecto
            this.oBorracho = new EstrategiaOjitos();
        }

        ////Primera Forma

        //public void EstablecerConquistaOjitos()
        //{
        //    this.oBorracho = new EstrategiaOjitos();
        //}

        //public void EstablecerConquistaInvitarCerveza()
        //{
        //    this.oBorracho = new EstrategiaInvitarCerveza();
        //}

        //public void Conquistar()
        //{
        //    this.oBorracho.Conquistar();
        //}

        //Segunda Forma
        public enum Comportamiento
        {
            HacerOjitos,
            InvitarCerveza
        }

        public void Conquistar(Comportamiento opcion)
        {
            switch (opcion)
            {
                case (Comportamiento.HacerOjitos):
                    {
                        this.oBorracho = new EstrategiaOjitos();
                    }
                    break;
                case (Comportamiento.InvitarCerveza):
                    {
                        this.oBorracho = new EstrategiaInvitarCerveza();
                    }
                    break;
            }

            this.oBorracho.Conquistar();
        }
    }
}
