using System;
using System.Collections.Generic;
using System.Text;

namespace _06_State
{
    public class CaidoServerState : ServerState
    {
        public override void Respuesta()
        {
            Console.WriteLine("Respuesta 503");
        }
    }
}
