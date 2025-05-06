using ToDoData.Models;

namespace TaskManager.Repositories.Interfaces
{
    public interface IToDoRepository
    {
        IEnumerable<ToDo> GetToDos();
    }
}
