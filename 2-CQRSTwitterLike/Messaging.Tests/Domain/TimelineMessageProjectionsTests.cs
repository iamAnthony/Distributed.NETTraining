using System;
using NFluent;
using NUnit.Framework;
using Messaging.Infrastructure;
using Messaging.Domain;


namespace Messaging.Tests.Domain
{
    [TestFixture]
    public class TimelineMessageProjectionsTests
    {
        [Test]
        public void WhenHandleMessagePublished_ThenTimelineMessageIsSavedForAuthor()
        {
            var publishDate = DateTime.Now;
            var authorId = new UserId("2");
            var content = "hello";
            var nbRepublish = 0;

            var messagePublished = new MessagePublished(authorId, publishDate, content, nbRepublish);
            // TODO : FakeTimelineRepository is a fake implementation of interface for tests purpose only -> keep it in test assembly
            var timelineMessageRepositoryFake = new FakeTimelineRepository();
            var timelineMessageProjections = new TimelineMessageProjections(timelineMessageRepositoryFake);

            timelineMessageProjections.Handle(messagePublished);

            

            var expectedTimelineMessage = new TimelineMessage(authorId, publishDate, authorId, content, nbRepublish);
            Check.That(timelineMessageRepositoryFake.Messages).ContainsExactly(expectedTimelineMessage);
        }

        [Test]
        public void WhenFollowerPublishAMessage_ThenItAppearsOnMyTimeline()
        {
            
        }

        [Test]
        public void WhenFollowerRepublishAMessage_ThenIt()
        {
            
        }

        [Test]
        public void WhenIDeleteAMessage_ThenItDisapearFromTimeline()
        {
            
        }

        // TODO : repeat for some more Events : FollowerMessagePublished, FollowerMessageRepublished, FollowerMessageLiked, MessageDeleted...
    }
}
