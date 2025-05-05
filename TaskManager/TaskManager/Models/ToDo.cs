using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ToDoData.Models
{
    public class ToDo
    {
        public int Id { get;set; }

        public required string ToDoText { get; set; }

        public DateTime ToDoDate { get; set; }

        public int ItemState { get; set; }
    }
}