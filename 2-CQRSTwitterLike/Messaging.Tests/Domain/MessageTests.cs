using NFluent;
using NUnit.Framework;

namespace Messaging.Tests.Domain
{
    [TestFixture]
    public class MessageTests
    {
        //[Test]
        //public void WhenPublishAMessage_ThenMessagePublishedIsPublished()
        //{
        //    IEventPublisher eventPublisher = new FakeEventPublisher();
        //    var message = new Message(); // aggregate, NO parameters, never inject in aggregate roots

        //    message.Publish(/*TODO : add paramters for command PublishMessage */, eventPublisher);

        //    var expectedEvent = new MessagePublished();
        //    Check.That(eventPublisher.Events).Contains(expectedEvent);
        //}

        // TODO : repeat for other commands : RepublishMessage, LikeMessage, DeleteMessage...
    }
}
