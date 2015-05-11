using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Domain
{
    public class MessagePublished
    {

        private static long messageid = 0;
        private readonly long myId;
        private readonly UserId authorId;
        private readonly DateTime publishDate;
        private readonly string content;
        private readonly int nbRepublish;


        public MessagePublished( UserId authorId, DateTime publishDate, string content, int nbRepublish)
        {
            this.myId = ++messageid;
            this.authorId = authorId;
            this.publishDate = publishDate;
            this.content = content;
            this.nbRepublish = nbRepublish;
        }

        public static long Messageid
        {
            get { return messageid; }
        }

        public DateTime PublishDate
        {
            get { return publishDate; }
        }

        public string Content
        {
            get { return content; }
        }

        public int NbRepublish
        {
            get { return nbRepublish; }
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
