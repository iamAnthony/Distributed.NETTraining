using NFluent;
using NUnit.Framework;

namespace Messaging.Tests.Infrastructure
{
    [TestFixture]
    public class EventPublisherTests
    {
        //[Test]
        //public void WhenPublishAnEvent_ThenSubscribersReceiveTheEvent()
        //{
        //    var eventPublisher = new EventPublisherTests();
        //    IHandles<EventA> subscriber = new FakeEventASubscriber(); // TODO : EventA is a fake subscriber for tests purpose only => make emerge IHandles<TEvent> interface for all subscribers
        //    eventPublisher.Subscribe<EventA>(subscriber);
        //    var eventA = new EventA(); // TODO : EventA is a fake event for tests purpose only

        //    eventPublisher.Publish();

        //    Check.That(subscriber.Events).ContainsExactly(eventA);
        //}
    }
}
