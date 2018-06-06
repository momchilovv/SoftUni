namespace WebServer.Application.Views
{
    using Server.Contracts;

    public class AboutView : IView
    {
        public string View()
        {
            return "<h3> About page: </h3>" +
                "<p> This is the test of the view controller adding in our ASP.NET MVC Project! <p>";
        }
    }
}