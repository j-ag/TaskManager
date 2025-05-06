using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Net;
using TaskManager.Client.DTOs;
using TaskManager.Services;
using TaskManager.Services.Interfaces;

namespace TaskManager.Controller
{
    [Route("api/[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _toDoService;

        public ToDoController(IToDoService toDoService)
        { 
            _toDoService = toDoService;
        }

        [HttpGet]
        public IEnumerable<ToDo> GetToDoItems()
        {
            var toDoItems = _toDoService.Get();

            // perform DTO mapping here. Use AUTOMAPPER. we want to return the DTO to client side.

            return new List<ToDo>();

            //return toDoItems;
        }
    }
}
