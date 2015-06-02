using System;

namespace Messaging.Domain
{
    public class MessagePublished : IDomainEvent
    {

        private static long messageid = 0;
        private readonly long myId;
        private readonly UserId authorId;
        private readonly DateTime publishDate;
        private readonly string content;


        public MessagePublished( UserId authorId, DateTime publishDate, string content)
        {
            this.myId = ++messageid;
            this.authorId = authorId;
            this.publishDate = publishDate;
            this.content = content;
        }

        public DateTime PublishDate
        {
            get { return publishDate; }
        }

        public string Content
        {
            get { return content; }
        }


        public long MyId
        {
            get { return myId; }
        }

        public UserId AuthorId
        {
            get { return authorId; }
        }
    }
}
