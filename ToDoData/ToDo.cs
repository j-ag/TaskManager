using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ToDoData
{
    public class ToDo
    {
        [Key]
        public int ToDoID { get;set; }

        public required string ToDoText { get; set; }

        public DateTime ToDoDate { get; set; }

        public int ItemState { get; set; }
    }
}