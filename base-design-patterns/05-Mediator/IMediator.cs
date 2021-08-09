using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Mediator
{
    public interface IMediator
    {
        void Send(string mensaje, IColleague colleague);
    }
}
