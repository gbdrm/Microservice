namespace MessageService
{
    public class Message
    {
        /// <remark>
        /// Generated on save
        /// </remark>
        public string Id { get; set; }

        /// <summary>
        /// A list of recipient ids.
        /// </summary>
        public string[] Recipients { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        /// <summary>
        /// True if message has been delivered by notification service.
        /// </summary>
        public bool IsSent { get; set; }
    }
}