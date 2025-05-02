using System.Threading.Tasks;
using System.Net.Http.Json;
using ToDoData;

namespace TaskManager.Client.TaskService
{
    public class TaskService
    {
        public static async Task<List<ToDo>> GetToDos()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetFromJsonAsync<List<ToDo>>("https://localhost:7031/api/todo");

            return response;
        }


    }
}
