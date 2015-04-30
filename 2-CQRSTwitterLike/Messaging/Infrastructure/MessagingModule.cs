using System;
using Nancy;

namespace Messaging.Infrastructure
{
    public struct TimelineMessage
    {
        private readonly string owner;
        private readonly string author;
        private readonly DateTime date;
        private readonly int nbFav;
        private readonly int nbRT;
        private readonly string content;

        public TimelineMessage(string owner, string author, DateTime date, int nbFav, int nbRt, string content)
        {
            
            this.owner = owner;
            this.author = author;
            this.date = date;
            this.nbFav = nbFav;
            this.nbRT = nbRt;
            this.content = content;
        }

        public string Owner
        {
            get { return owner; }
        }

        public string Author
        {
            get { return author; }
        }

        public DateTime Date
        {
            get { return date; }
        }

        public int NbFav
        {
            get { return nbFav; }
        }

        public int NbRt
        {
            get { return nbRT; }
        }

        public string Content
        {
            get { return content; }
        }
    }

    public class MessagingModule : NancyModule
    {
        public MessagingModule()
        {
            Get["/hello"] = _ => "Hello world!";
            Get["/messaging/timelineMessages"] = OnTimelineMessagesRequested;
        }

        private object OnTimelineMessagesRequested(object arg)
        {
            throw new NotImplementedException();
        }
    }
}
