using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging.Infrastructure
{
    public class TimelineMessageRepository
    {
        private IEnumerable<TimelineMessage> myAttribute;
        public TimelineMessageRepository(IEnumerable<TimelineMessage> getFakeTimelineMessages)
        {
            myAttribute = getFakeTimelineMessages;
        }

        public IEnumerable<TimelineMessage> GetLastMessagesForUser(UserId userId, int i)
        {
            // TODO
        }
    }
}