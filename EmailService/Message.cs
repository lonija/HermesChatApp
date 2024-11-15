﻿using MimeKit;

namespace EmailService
{
    public class Message
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public Message(IEnumerable<string> to, string subject, string content)
        {
            // Need modification !!!
            To = new List<MailboxAddress>();

            To.AddRange(to.Select(x =>
            {
                return new MailboxAddress("", x);
            }));
            Subject = subject;
            Content = content;
        }
    }
}
