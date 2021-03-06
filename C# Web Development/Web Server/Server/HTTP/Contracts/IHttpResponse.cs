namespace WebServer.Server.HTTP.Contracts
{
    using Enums;
    
    public interface IHttpResponse
    {
        HttpStatusCode StatusCode { get; }

        HttpHeaderCollection Headers { get; }  
    }
}