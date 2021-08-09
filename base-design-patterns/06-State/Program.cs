using System;

namespace _06_State
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerContext serverContext = new ServerContext();
            serverContext.State = new DisponibleServerState();
            serverContext.AtenderSolicitud();

            serverContext.State = new SaturadoServerState();
            serverContext.AtenderSolicitud();
        }
    }
}
