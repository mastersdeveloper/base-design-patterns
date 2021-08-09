using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Mediator
{
    public class User : IColleague
    {
        public User(IMediator mediator) : base(mediator)
        {

        }

        public override void Receive(string mensaje)
        {
            Console.WriteLine("Un usuario recibe: " + mensaje);
        }
    }
}
