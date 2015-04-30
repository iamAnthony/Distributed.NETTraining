using System;
using System.Collections.Generic;
using System.Linq;
using Messaging.Infrastructure;
using NFluent;
using NUnit.Framework;

namespace Messaging.Tests.Domain
{
    [TestFixture]
    public class TimelineMessageRepositoryTests
    {
        [Test]
        public void WhenGetLast5MessagesForKnownUserId_ThenItReturns5MostRecentMessages()
        {
            var userId = new UserId();
            var repository = new TimelineMessageRepository(GetFakeTimelineMessages(10, userId));

            IEnumerable<TimelineMessage> result = repository.GetLastMessagesForUser(userId, 5);

            Check.That(result).HasSize(5);
            // TODO add a Check on PublishedDate Check.That(result).Contains();
        }

        //[Test]
        //public void WhenGetLast5MessagesForKnownUser_ThenItDoesNotReturnMessagesFromAnotherUser()
        //{
        //    var userId = new UserId();
        //    var anotherUserId = new UserId();
        //    var repository = new TimelineMessageRepository(GetFakeTimelineMessages(10, userId, anotherUserId));

        //    IEnumerable<TimelineMessage> result = repository.GetLastMessagesForUser(userId, 5);

        //    // TODO add a Check on UserId Check.That(result).Contains();
        //}

        private IEnumerable<TimelineMessage> GetFakeTimelineMessages(int nbMessages, params UserId[] userIds)
        {
            var random = new Random();
            for (int i = 0; i < nbMessages; i++)
            {
                var currentUserId = userIds[i % userIds.Count()];
                var currentPublishedDate = DateTime.Now.AddHours(random.Next(-nbMessages * 10, nbMessages * 10));
                yield return new TimelineMessage(i, currentUserId, currentUserId, currentPublishedDate, 0,0,"");
            }
        }
    }
}
