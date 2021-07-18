using SepSampleCodeBase.Application.Common.Mappings;
using SepSampleCodeBase.Domain.Entities;

namespace SepSampleCodeBase.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
