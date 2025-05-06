using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ToDos
    {
        public int Id { get;set; }

        public required string ToDoText { get; set; }

        public DateTime ToDoDate { get; set; }

        public int ItemState { get; set; }
    }
}