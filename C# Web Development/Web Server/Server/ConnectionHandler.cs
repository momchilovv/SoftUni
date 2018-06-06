namespace WebServer.Server.Handlers
{
    using HTTP;
    using System;
    using Validation;
    using System.Text;
    using HTTP.Contracts;
    using Routing.Contracts;
    using System.Net.Sockets;
    using System.Threading.Tasks;
    using System.Linq;
    using System.Globalization;

    public class ConnectionHandler
    {
        private readonly Socket client;

        private readonly IServerRouteConfig serverRouteConfig;

        public ConnectionHandler(Socket client, IServerRouteConfig serverRouteConfig)
        {
            Validation.ThrowIfNull(client, nameof(client));
            Validation.ThrowIfNull(serverRouteConfig, nameof(serverRouteConfig));

            this.client = client;
            this.serverRouteConfig = serverRouteConfig;
        }
        public async Task ProcessRequestAsync()
        {
            var httpRequest = await this.ReadRequest();

            var httpContext = new HttpContext(httpRequest);

            var httpResponse = new HttpHandler(this.serverRouteConfig).Handle(httpContext);

            var toBytes = new ArraySegment<byte>(Encoding.UTF8.GetBytes(httpResponse.ToString()));

            await this.client.SendAsync(toBytes, SocketFlags.None);

            Console.WriteLine("******************[REQUEST]******************");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(httpRequest);
            Console.WriteLine();
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine("*****************[RESPONSE]******************");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(httpResponse);
            Console.WriteLine();
            Console.WriteLine("*********************************************");
            Console.WriteLine();

            this.client.Shutdown(SocketShutdown.Both);
        }

        private async Task<IHttpRequest> ReadRequest()
        {
            var result = new StringBuilder();

            var data = new ArraySegment<byte>(new byte[1024]);

            while (true)
            {
                int numBytesRead = await this.client.ReceiveAsync(data, SocketFlags.None);

                if (numBytesRead == 0)
                {
                    break;
                }

                var bytesAsString = Encoding.UTF8.GetString(data.Array, 0, numBytesRead);

                result.Append(bytesAsString);

                if (numBytesRead < 1024)
                {
                    break;
                }

            }
        
            return new HttpRequest(result.ToString());
        }
    }
}