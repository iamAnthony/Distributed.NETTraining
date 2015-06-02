using System.Collections.Generic;
using System.Linq;
using Messaging.Domain;

namespace Messaging.Infrastructure
{
    public class TimelineMessageRepository : ITimelineMessageRepository
    {
        private List<TimelineMessage> _initialElements;

        public TimelineMessageRepository()
        {
            _initialElements = new List<TimelineMessage>();
        }

        public TimelineMessageRepository(IEnumerable<TimelineMessage> initialElements)
        {
            _initialElements = new List<TimelineMessage>(initialElements);
        }

        public IEnumerable<TimelineMessage> GetLastMessagesForUser(UserId userId, int i)
        {
            return _initialElements
                .Where(x => x.OwnerId.Equals(userId))
                .OrderByDescending(x => x.PublishDate)
                .Take(i);
        }

        public void Save(TimelineMessage mp)
        {
            _initialElements.Add(mp);
        }

        public TimelineMessage GetTimelineMessageById(long id)
        {
            return _initialElements.SingleOrDefault(s => s.MessageId.Equals(id));
        }

        public void Delete(long id)
        {
            _initialElements.RemoveAll(s => s.MessageId.Equals(id));
        }
    }
}