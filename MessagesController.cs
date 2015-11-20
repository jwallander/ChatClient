using System.Net;
using System.Net.Http;
using System.Web.Http;

// ReSharper disable UnusedMember.Global
namespace JonasWallander.ChatClient
{
    public class MessagesController : ApiController
    {
        private static readonly IMessageDispatcher Dispatcher = MessageDispatcher.Instance;

        public HttpResponseMessage PostMessage([FromBody]Message message)
        {
            Dispatcher.Dispatch(message);
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
}
