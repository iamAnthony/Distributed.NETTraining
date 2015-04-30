using NFluent;
using NUnit.Framework;

namespace Messaging.Tests.Domain
{
    [TestFixture]
    public class TimelineMessageProjectionsTests
    {
        //[Test]
        //public void WhenHandleMessagePublished_ThenTimelineMessageIsSavedForAuthor()
        //{
        //    var messagePublished = new MessagePublished(/* TODO add parameters -> immutability */);
        //    // TODO : FakeTimelineRepository is a fake implementation of interface for tests purpose only -> keep it in test assembly
        //    ITimelineMessageRepository timelineMessageRepositoryFake = new FakeTimelineRepository();
        //    var timelineMessageProjections = new TimelineMessageProjections(timelineMessageRepositoryFake);

        //    timelineMessageProjections.Handle(messagePublished);

        //    var expectedTimelineMessage = new TimelineMessage(/* TODO add parameters to instanciate the expected object after handle call */);
        //    Check.That(timelineMessageRepositoryFake.Messages).ContainsExactly();
        //}

        // TODO : repeat for some more Events : FollowerMessagePublished, FollowerMessageRepublished, FollowerMessageLiked, MessageDeleted...
    }
}
