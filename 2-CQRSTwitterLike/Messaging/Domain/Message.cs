using System;

namespace Messaging.Domain
{
    public class Message
    {
        public Message()
        {
        }

        public void Publish(UserId authorId, DateTime publishDate, string content, IEventPublisher eventPublisher)
        {
            if (content.Length > 140)
            {
                throw new NoMoreThan140Characters();
            }
            MessagePublished mp = new MessagePublished(authorId, publishDate, content);
            eventPublisher.SaveEvent(mp);
        }

        public void Republish(long myId, UserId authorId, DateTime now, IEventPublisher eventPublisher)
        {
            var mr = new MessageRepublished(myId, authorId, now);
            eventPublisher.SaveEvent(mr);
        }
    }

}

public class NoMoreThan140Characters : Exception
{
    public NoMoreThan140Characters() : base()
    {
    }

    public NoMoreThan140Characters(string message) : base(message)
    {
    }

    public NoMoreThan140Characters(string message, Exception innerException) : base(message, innerException)
    {
    }
}