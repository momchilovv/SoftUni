using WebServer.Application;
using WebServer.Server;
using WebServer.Server.Contracts;
using WebServer.Server.Routing;
using WebServer.Server.Routing.Contracts;

public class Launcher : IRunnable
{
    public static void Main()
    {
        new Launcher().Run();
    }

    public void Run()
    {
        IApplication app = new MainApplication();
        IAppRouteConfig appRouteConfig = new AppRouteConfig();
        app.Start(appRouteConfig);

        var runWebServer = new RunWebServer(1337, appRouteConfig);
        runWebServer.Run();
    }
}