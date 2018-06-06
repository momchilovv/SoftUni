namespace WebServer.Server.Routing
{
    using Handlers;
    using Contracts;
    using WebServer.Server.Validation;
    using System.Collections.Generic;

    public class RoutingContext : IRoutingContext
    {
        public RoutingContext(RequestHandler requestHandler, IEnumerable<string> parameters)
        {
            Validation.ThrowIfNull(requestHandler, nameof(requestHandler));
            Validation.ThrowIfNull(parameters, nameof(parameters));

            this.RequestHandler = requestHandler;
            this.Parameters = parameters;
        }

        public IEnumerable<string> Parameters { get; private set; }

        public RequestHandler RequestHandler { get; private set; }
    }
}