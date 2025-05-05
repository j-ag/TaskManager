namespace TaskManager.Client.DTOs
{
    public class ToDo
    {
        public int ToDoID { get;set; }

        public required string ToDoText { get; set; }

        public DateTime ToDoDate { get; set; }

        public int ItemState { get; set; }
    }
}