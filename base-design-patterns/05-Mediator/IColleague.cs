using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Mediator
{
    public abstract class IColleague
    {
        private IMediator mediator;

        public IMediator Mediator
        {
            get;
        }

        public IColleague(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Comunicate(string mensaje)
        {
            this.mediator.Send(mensaje, this);
        }

        public abstract void Receive(string mensaje);
    }
}
