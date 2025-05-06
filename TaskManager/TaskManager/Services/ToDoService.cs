using TaskManager.Repositories.Interfaces;
using TaskManager.Services.Interfaces;
using Models;

namespace TaskManager.Services
{
    public class ToDoService : IToDoService
    {
        private IToDoRepository _toDoRepository;

        public ToDoService(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public IEnumerable<ToDos> Get()
        {
            return _toDoRepository.GetToDos();
        }
    }
}
