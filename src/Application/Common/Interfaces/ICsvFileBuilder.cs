using SepSampleCodeBase.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace SepSampleCodeBase.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
