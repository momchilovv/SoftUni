namespace WebServer.Application
{
    using WebServer.Application.Controllers;
    using WebServer.Server.Contracts;
    using WebServer.Server.Handlers;
    using WebServer.Server.Routing.Contracts;

    public class MainApplication : IApplication
    {
        public void Start(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig.AddRoute("/", new GetHandler(httpContext => new HomeController().Index()));

            appRouteConfig.AddRoute("/about", new GetHandler(httpContext => new HomeController().About()));

            appRouteConfig.AddRoute("/register", new PostHandler(httpContext => new UserController().RegisterPost(httpContext.FormData["name"])));

            appRouteConfig.AddRoute("/register", new GetHandler(httpContext => new UserController().RegisterGet()));

            appRouteConfig.AddRoute("/user/{(?<name>[a-z]+)}", new GetHandler(httpContext => new UserController().Details(httpContext.UrlParameters["name"])));
        }
    }
}