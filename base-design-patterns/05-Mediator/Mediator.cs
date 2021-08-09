using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Mediator
{
    public class Mediator : IMediator
    {
        private List<IColleague> colleagues;

        public Mediator()
        {
            colleagues = new List<IColleague>();
        }

        public void Add(IColleague colleague)
        {
            this.colleagues.Add(colleague);
        }

        public void Send(string mensaje, IColleague colleague)
        {
            foreach (var c in this.colleagues)
            {
                if (colleague != c)
                {
                    c.Receive(mensaje);
                }
            }
        }
    }
}
