using System;
using Nancy;

namespace Messaging.Infrastructure
{
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
