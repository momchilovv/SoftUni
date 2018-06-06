namespace WebServer.Server.Handlers
{
    using Contracts;
    using Validation;
    using HTTP.Contracts;
    using System;
    using HTTP;

    public abstract class RequestHandler : IRequestHandler
    {
        private readonly Func<IHttpRequest, IHttpResponse> handlingFunc;

        protected RequestHandler(Func<IHttpRequest, IHttpResponse> handlingFunc)
        {
            Validation.ThrowIfNull(handlingFunc, nameof(handlingFunc));

            this.handlingFunc = handlingFunc;
        }

        public IHttpResponse Handle(IHttpContext httpContext)
        {
            IHttpResponse response = this.handlingFunc(httpContext.Request);

            response.Headers.Add(new HttpHeader("Content Type", "text/plain"));

            return response;
        }
    }
}