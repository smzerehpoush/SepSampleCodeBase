using SepSampleCodeBase.Domain.Common;
using SepSampleCodeBase.Domain.Entities;

namespace SepSampleCodeBase.Domain.Events
{
    public class TodoItemCompletedEvent : DomainEvent
    {
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
