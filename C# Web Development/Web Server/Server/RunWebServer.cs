namespace WebServer.Server
{
    using System;
    using Routing;
    using Contracts;
    using System.Net;
    using Routing.Contracts;
    using System.Net.Sockets;
    using System.Threading.Tasks;
    using WebServer.Server.Handlers;

    public class RunWebServer : IRunnable
    { 
        private readonly int port;

        private readonly IServerRouteConfig serverRouteConfig;

        private readonly TcpListener tcpListener;

        private bool isRunning;

        public RunWebServer(int port, IAppRouteConfig appRouteConfig)
        {
            this.port = port;
            this.tcpListener = new TcpListener(IPAddress.Parse("192.168.0.101"), port);

            this.serverRouteConfig = new ServerRouteConfig(appRouteConfig);
        }

        public void Run()
        {
            this.tcpListener.Start();

            this.isRunning = true;

            Console.WriteLine($"Server started. Listening to TCP clients at 127.0.0.1:{port}");

            Task.Run(this.ListenerLoop).Wait();
        }

        private async Task ListenerLoop()
        {
            while (this.isRunning)
            {
                Socket client = await this.tcpListener.AcceptSocketAsync();
                ConnectionHandler connectionHandler = new ConnectionHandler(client, this.serverRouteConfig);
                await connectionHandler.ProcessRequestAsync();
            }
        }
    }
}