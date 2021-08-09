using System;

namespace _05_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();

            IColleague user01 = new User(mediator);

            IColleague user02 = new UserAdmin(mediator);

            mediator.Add(user01);
            mediator.Add(user02);

            user01.Comunicate("Oye admin tengo un problema");
        }
    }
}
