using TaskManager.Repositories.Interfaces;
using TaskManager.Services.Interfaces;
using ToDoData.Models;

namespace TaskManager.Services
{
    public class ToDoService : IToDoService
    {
        private IToDoRepository _toDoRepository;

        public ToDoService(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public IEnumerable<ToDo> Get()
        {
            return _toDoRepository.GetToDos();
        }
    }
}
