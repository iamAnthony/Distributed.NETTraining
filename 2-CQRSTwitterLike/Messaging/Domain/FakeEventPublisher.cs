using System.Collections.Generic;
using System.Linq;

namespace Messaging.Domain
{
    public class FakeEventPublisher : IEventPublisher
    {
        private List<IDomainEvent> _events;

        public FakeEventPublisher()
        {
            _events = new List<IDomainEvent>();
        }

        public void SaveEvent(IDomainEvent mp)
        {
            _events.Add(mp);
        }

        public List<IDomainEvent> Events
        {
            get { return _events; }
        }
    }
}