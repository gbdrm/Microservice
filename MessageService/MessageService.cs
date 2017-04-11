using Nancy;

namespace MessageService
{
    public class MessageService : NancyModule
    {
        private readonly MessageRepository _repository = new MessageRepository();
        private dynamic _messageQueue;

        public MessageService()
        {
            Get["/"] = _ => "OK";

            Post["/send"] = message => ProcessMessage(message);
        }

        private string ProcessMessage(dynamic message)
        {
            var msg = new Message
            {
                Body = "test"
            };

            string id = _repository.Save(msg);
            msg.Id = id;

            _messageQueue.Dispatch(msg);
            return id;
        }
    }
}