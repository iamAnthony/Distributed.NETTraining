namespace Messaging.Domain
{
    public interface IEventPublisher
    {
        void SaveEvent(IDomainEvent mp);


    }

}