using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Mediator
{
    public class UserAdmin : IColleague
    {
        public UserAdmin(IMediator mediator) : base(mediator)
        {

        }

        public override void Receive(string mensaje)
        {
            Console.WriteLine("Un administrador recive: " + mensaje);
        }
    }
}
