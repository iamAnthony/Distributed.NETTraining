using System;
using System.Collections.Generic;
using System.Linq;
using Messaging.Domain;
using Messaging.Infrastructure;
using Nancy;
using Nancy.TinyIoc;

namespace AspNetNancyHost
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);
            container.Register<ITimelineMessageRepository>(new TimelineMessageRepository(GetFakeTimelineMessages(10, new UserId("1"), new UserId("2"))));
        }

        private IEnumerable<TimelineMessage> GetFakeTimelineMessages(int nbMessages, params UserId[] userIds)
        {
            var random = new Random();
            for (int i = 0; i < nbMessages; i++)
            {
                var currentUserId = userIds[i % userIds.Count()];
                var currentPublishedDate = DateTime.Now.AddHours(random.Next(-nbMessages * 10, nbMessages * 10));
                yield return new TimelineMessage(currentUserId, currentPublishedDate, new UserId("3"), "hello " + i, 0, 0);
            }
        }
    }
}