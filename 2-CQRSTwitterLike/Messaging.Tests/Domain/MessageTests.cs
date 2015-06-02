using System;
using System.Linq;
using Messaging.Domain;
using NFluent;
using NUnit.Framework;

namespace Messaging.Tests.Domain
{
    [TestFixture]
    public class MessageTests
    {
        [Test]
        public void WhenPublishAMessage_ThenMessagePublishedIsPublished()
        {
            UserId authorId = new UserId("Antho");
            DateTime date = DateTime.Now;
            var eventPublisher = new FakeEventPublisher();
            var message = new Message(); // aggregate, NO parameters, never inject in aggregate roots

            try
            {
                message.Publish(authorId, date, "coucou", eventPublisher);
            }
            catch (NoMoreThan140Characters e)
            {
                throw e;
            }

            Check.That(eventPublisher.Events).Not.IsEmpty();
        }

        [Test]
        public void WhenRepublishAMessage_ThenMessagePublishedHasNbRepublishedIncremented()
        {
            UserId authorId = new UserId("Antho");
            DateTime date = DateTime.Now;
            var eventPublisher = new FakeEventPublisher();
            var message = new Message(); // aggregate, NO parameters, never inject in aggregate roots

            message.Publish(authorId, date, "coucou", eventPublisher);

            MessagePublished mp = (MessagePublished) eventPublisher.Events.Last();

            message.Republish(mp.MyId, authorId, DateTime.Now, eventPublisher);

            Check.That(eventPublisher.Events.Count).Equals(2);
        }


        // TODO : repeat for other commands : RepublishMessage, LikeMessage, DeleteMessage...
    }
}
