using TaskManager.Repositories.Interfaces;
using ToDoData.Models;

namespace TaskManager.Repositories
{
    public class ToDoRepository : IToDoRepository, IDisposable
    {
        private ToDoDBContext _dbContext;

        public ToDoRepository(ToDoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ToDo> GetToDos()
        {
            return _dbContext.ToDo.ToList();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
