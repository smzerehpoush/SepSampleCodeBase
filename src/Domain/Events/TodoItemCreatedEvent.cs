using SepSampleCodeBase.Domain.Common;
using SepSampleCodeBase.Domain.Entities;

namespace SepSampleCodeBase.Domain.Events
{
    public class TodoItemCreatedEvent : DomainEvent
    {
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
