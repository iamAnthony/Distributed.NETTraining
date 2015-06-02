using System.Collections.Generic;
using System.Linq.Expressions;
using Messaging.Domain;

namespace Messaging.Infrastructure
{
    public interface ITimelineMessageRepository
    {
        IEnumerable<TimelineMessage> GetLastMessagesForUser(UserId userId, int i);

        void Save(TimelineMessage mp);

        TimelineMessage GetTimelineMessageById(long id);

        void Delete(long originalMessageId);
    }
}