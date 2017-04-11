using System.Collections.Generic;

namespace MessageService
{
    internal class MessageRepository
    {
        List<Message> _messages = new List<Message>();
        internal string Save(Message msg)
        {
            msg.Id = _messages.Count.ToString();
            _messages.Add(msg);

            return msg.Id;
        }
    }
}