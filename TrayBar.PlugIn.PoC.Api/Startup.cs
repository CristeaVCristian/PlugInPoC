using System.Web.Http;
using Microsoft.Owin;
using Owin;
using TrayBar.PlugIn.PoC.Api;

[assembly: OwinStartup(typeof(Startup))]

namespace TrayBar.PlugIn.PoC.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            config.EnableCors();

            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultWebApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            app.UseWebApi(config);
        }
    }
}
