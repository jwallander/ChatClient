using System.Web.Http;
using Owin;

namespace JonasWallander.ChatClient
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class ChatServer
    {
        // ReSharper disable once UnusedMember.Global
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });

            appBuilder.UseWebApi(config);
        }
    }
}