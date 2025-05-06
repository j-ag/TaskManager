using ToDoData.Models;

namespace TaskManager.Services.Interfaces
{
    public interface IToDoService
    {

        IEnumerable<ToDo> Get();
    }
}
