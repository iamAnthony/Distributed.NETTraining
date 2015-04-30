using System;
using Messaging.Infrastructure;
using NFluent;
using NUnit.Framework;

namespace Messaging.Tests.Domain
{
    [TestFixture]
    public class TimelineMessageTests
    {

        private UserId uid;

        public UserId Uid
        {
            get { return uid; }
        }

        [SetUp]
        public void newUser()
        {
            uid = new UserId();
        }

        [Test]
        public void WhenInstanciateTimelineMessage_ThenCanGetEachProperties()
        {

            var timelineMessage = new TimelineMessage(0,Uid,Uid,DateTime.Today, 0, 0, "Hello World!");
            
            Check.That(timelineMessage.Id).IsEqualTo(0);
            Check.That(timelineMessage.Owner).IsEqualTo(Uid);
            Check.That(timelineMessage.Author).IsEqualTo(Uid);
            Check.That(timelineMessage.Date).IsEqualTo(DateTime.Today);
            Check.That(timelineMessage.NbFav).IsEqualTo(0);
            Check.That(timelineMessage.NbRt).IsEqualTo(0);
            Check.That(timelineMessage.Content).IsEqualTo("Hello World!");
        }

        [Test]
        public void WhenInstanciateTwoTimelineMessageWithSameProperties_ThenTheyAreEquals()
        {
            var timelineMessage1 = new TimelineMessage(0,Uid,Uid, DateTime.Today, 0, 0, "Hello World!");
            var timelineMessage2 = new TimelineMessage(0,Uid, Uid, DateTime.Today, 0, 0, "Hello World!");

            Check.That(timelineMessage1).IsEqualTo(timelineMessage2);
        }
    }
}
