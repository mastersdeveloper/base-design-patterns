using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _06_State
{
    public class SaturadoServerState : ServerState
    {
        public override void Respuesta()
        {
            Task.Delay(500);
            Console.WriteLine("Respuesta 200");
        }
    }
}
