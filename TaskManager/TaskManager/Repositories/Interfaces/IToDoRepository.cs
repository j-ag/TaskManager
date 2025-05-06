using Models;

namespace TaskManager.Repositories.Interfaces
{
    public interface IToDoRepository
    {
        IEnumerable<ToDos> GetToDos();
    }
}
