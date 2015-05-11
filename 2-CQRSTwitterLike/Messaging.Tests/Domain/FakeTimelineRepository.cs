﻿using System.Collections.Generic;
using Messaging.Domain;
using Messaging.Infrastructure;

namespace Messaging.Tests.Domain
{
    public class FakeTimelineRepository : ITimelineMessageRepository
    {

        private List<TimelineMessage> messages;

        public FakeTimelineRepository()
        {
            this.messages = new List<TimelineMessage> ();
        }

        public List<TimelineMessage> Messages
        {
            get { return messages; }
        }

        public IEnumerable<TimelineMessage> GetLastMessagesForUser(UserId userId, int i)
        {
            throw new System.NotImplementedException();
        }


        public void Save(TimelineMessage mp)
        {
            Messages.Add(mp);
        }
    }
}