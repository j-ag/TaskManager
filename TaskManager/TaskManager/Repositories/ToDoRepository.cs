using TaskManager.Repositories.Interfaces;
using Models;

namespace TaskManager.Repositories
{
    public class ToDoRepository : IToDoRepository, IDisposable
    {
        private ToDoDBContext _dbContext;

        public ToDoRepository(ToDoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ToDos> GetToDos()
        {
            return _dbContext.ToDos.ToList();
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
