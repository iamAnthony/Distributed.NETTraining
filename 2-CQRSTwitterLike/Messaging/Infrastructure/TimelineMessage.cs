using System;

namespace Messaging.Infrastructure
{
    public struct TimelineMessage
    {
        private readonly long id;
        private readonly UserId owner;
        private readonly UserId author;
        private readonly DateTime date;
        private readonly int nbFav;
        private readonly int nbRT;
        private readonly string content;

        public TimelineMessage(long id, UserId owner, UserId author, DateTime date, int nbFav, int nbRT, string content)
        {
            this.id = id;
            this.owner = owner;
            this.author = author;
            this.date = date;
            this.nbFav = nbFav;
            this.nbRT = nbRT;
            this.content = content;
        }


        public UserId Owner
        {
            get { return owner; }
        }

        public UserId Author
        {
            get { return author; }
        }

        public DateTime Date
        {
            get { return date; }
        }

        public int NbFav
        {
            get { return nbFav; }
        }

        public int NbRt
        {
            get { return nbRT; }
        }

        public string Content
        {
            get { return content; }
        }

        public long Id
        {
            get { return id; }
        }
    }
}