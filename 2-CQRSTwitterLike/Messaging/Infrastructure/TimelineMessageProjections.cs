using Messaging.Domain;

namespace Messaging.Infrastructure
{
    public class TimelineMessageProjections
    {

        private ITimelineMessageRepository itmr;

        public TimelineMessageProjections(ITimelineMessageRepository timelineMessageRepositoryFake)
        {
            this.itmr = timelineMessageRepositoryFake;
        }

        public void Handle(MessagePublished mp)
        {
            itmr.Save(new TimelineMessage(mp.AuthorId,mp.PublishDate, mp.AuthorId, mp.Content, mp.NbRepublish));
        }
    }
}