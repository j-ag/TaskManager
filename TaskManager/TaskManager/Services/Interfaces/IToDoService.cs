using Models;

namespace TaskManager.Services.Interfaces
{
    public interface IToDoService
    {

        IEnumerable<ToDos> Get();
    }
}
