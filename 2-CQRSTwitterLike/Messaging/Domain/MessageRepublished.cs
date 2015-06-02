using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Domain
{
    public class MessageRepublished : IDomainEvent
    {
        private readonly long _originalMessageId;
        private readonly UserId _authorId;
        private readonly DateTime _date;

        public MessageRepublished(long originalMessageId, UserId authorId, DateTime date)
        {
            _originalMessageId = originalMessageId;
            _authorId = authorId;
            _date = date;
        }

        public long OriginalMessageId
        {
            get { return _originalMessageId; }
        }

        public UserId AuthorId
        {
            get { return _authorId; }
        }

        public DateTime Date
        {
            get { return _date; }
        }
    }
}
