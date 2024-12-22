using CQRS.Core.Events;
namespace Post.Common.Events
{
    public class MessageUpdatedEvent : BaseEvents
    {
        public MessageUpdatedEvent() : base(nameof(MessageUpdatedEvent)) 
        {}

        public string Message { get;set;}   
    }
}