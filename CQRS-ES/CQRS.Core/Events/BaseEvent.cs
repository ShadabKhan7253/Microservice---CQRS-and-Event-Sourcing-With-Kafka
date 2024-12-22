using CQRS.Core.Messages;

namespace CQRS.Core.Events
{
    public abstract class BaseEvent : Message
    {
        protected BaseEvent(string type) 
        {
            this.Type = type;
        }

        public int version { get; set; }
        public string Type { get; set; }
    }
}