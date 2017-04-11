using Nancy;

namespace NancyExample
{
    public class MessageService : NancyModule
    {
        public MessageService()
        {
            Get["/"] = _ => "OK";
        }
    }
}