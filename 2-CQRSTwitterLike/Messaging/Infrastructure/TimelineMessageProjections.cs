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
            itmr.Save(new TimelineMessage(mp.AuthorId,mp.PublishDate, mp.AuthorId, mp.Content, 0, mp.MyId));
        }

        public void Handle(MessageRepublished mr)
        {
            var timelineMessageById = itmr.GetTimelineMessageById(mr.OriginalMessageId);
            timelineMessageById.IncrementNbRepublished();
            itmr.Delete(mr.OriginalMessageId);
            itmr.Save(timelineMessageById);
        }
    }
}