namespace WebServer.Server.HTTP.Response
{
    using Enums;
    using Server.Contracts;
    using Exceptions;

    public class ViewResponse : HttpResponse
    {
        private readonly IView view;

        public ViewResponse(HttpStatusCode statusCode, IView view)
        {
            this.ValidateStatusCode(statusCode);

            this.view = view;
            this.StatusCode = statusCode;
        }

        private void ValidateStatusCode(HttpStatusCode statusCode)
        {
            if (299 < (int)this.StatusCode && (int)this.StatusCode < 400)
            {
                throw new InvalidResponseException("Status code is not supported from view!");
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.view.View()}";
        }
    }
}