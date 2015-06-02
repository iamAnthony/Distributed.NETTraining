using System;
using Messaging.Domain;
using NFluent;
using NUnit.Framework;
using Messaging.Infrastructure;


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

            var messagePublished = new MessagePublished(authorId, publishDate, content);
            // TODO : FakeTimelineRepository is a fake implementation of interface for tests purpose only -> keep it in test assembly
            var timelineMessageRepositoryFake = new FakeTimelineRepository();
            var timelineMessageProjections = new TimelineMessageProjections(timelineMessageRepositoryFake);

            timelineMessageProjections.Handle(messagePublished);

            

            var expectedTimelineMessage = new TimelineMessage(authorId, publishDate, authorId, content, 0, messagePublished.MyId);
            Check.That(timelineMessageRepositoryFake.Messages).ContainsExactly(expectedTimelineMessage);
        }

        [Test]
        public void WhenFollowerPublishAMessage_ThenItAppearsOnMyTimeline()
        {
            
        }

        [Test]
        public void WhenPublishedMessageIsRepublished_ThenNbRepublishedIsIncremented()
        {
            //Actors = Given
            var publishDate = DateTime.Now;
            var authorId = new UserId("2");
            var republishedMessageAuthor = new UserId("3");
            var content = "hello";


            var messagePublished = new MessagePublished(authorId, DateTime.Now, content);

            var messageRepublished = new MessageRepublished(messagePublished.MyId, republishedMessageAuthor, DateTime.Now );

            var timelineMessageRepositoryFake = new FakeTimelineRepository();
            var timelineMessageProjections = new TimelineMessageProjections(timelineMessageRepositoryFake);
            timelineMessageRepositoryFake.Save(new TimelineMessage(authorId, publishDate, authorId, content, 0, messagePublished.MyId));
            //timelineMessageProjections.Handle(messagePublished);
            
            // Action = When
            timelineMessageProjections.Handle(messageRepublished);


            // Asserts = Then
            var messagePublishedNbRepublished =
                timelineMessageRepositoryFake.GetTimelineMessageById(messagePublished.MyId).NbRepublish;
            Check.That(messagePublishedNbRepublished).Equals(1);
        }

        [Test]
        public void WhenMessageDeleted_ThenItIsDeletedFromRepository()
        {
            var publishDate = DateTime.Now;
            var authorId = new UserId("2");
            var republishedMessageAuthor = new UserId("3");
            var content = "hello";


            var messagePublished = new MessagePublished(authorId, DateTime.Now, content);

            var timelineMessageRepositoryFake = new FakeTimelineRepository();
            var timelineMessageProjections = new TimelineMessageProjections(timelineMessageRepositoryFake);
            timelineMessageRepositoryFake.Save(new TimelineMessage(authorId, publishDate, authorId, content, 0, messagePublished.MyId));

            timelineMessageRepositoryFake.Delete(messagePublished.MyId);

            Check.That(timelineMessageRepositoryFake.Messages).IsEmpty();
        }

        // TODO : repeat for some more Events : FollowerMessagePublished, FollowerMessageRepublished, FollowerMessageLiked, MessageDeleted...
    }
}
