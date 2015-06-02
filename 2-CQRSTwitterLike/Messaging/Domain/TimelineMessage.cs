using System;

namespace Messaging.Domain
{
    public struct TimelineMessage
    {
        private readonly UserId _ownerId;
        private readonly DateTime _publishDate;
        private readonly UserId _authorId;
        private readonly string _content;
        private int _nbRepublish;
        private readonly long _messageId;

        public TimelineMessage(UserId ownerId, DateTime publishDate, UserId authorId, string content, int nbRepublish, long messageId)
        {
            _ownerId = ownerId;
            _publishDate = publishDate;
            _authorId = authorId;
            _content = content;
            _nbRepublish = nbRepublish;
            _messageId = messageId;
        }

        public UserId OwnerId
        {
            get { return _ownerId; }
        }

        public DateTime PublishDate
        {
            get { return _publishDate; }
        }

        public UserId AuthorId
        {
            get { return _authorId; }
        }

        public string Content
        {
            get { return _content; }
        }

        public int NbRepublish
        {
            get { return _nbRepublish; }
        }

        public long MessageId
        {
            get { return _messageId; }
        }

        public void IncrementNbRepublished()
        {
            _nbRepublish++;
        }
    }
}