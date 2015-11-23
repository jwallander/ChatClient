using System;
using System.Diagnostics;
using System.Web.Http;
using Owin;
using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>;

namespace JonasWallander.ChatClient
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class ChatServer
    {
        // ReSharper disable once UnusedMember.Global
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.Use(new Func<AppFunc, AppFunc>(next => (async env =>
            {
                Debug.WriteLine("Begin Request");
                await next.Invoke(env);
                Debug.WriteLine("End Request");
            })));

            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });
            appBuilder.UseWebApi(config);
        }
    }
}