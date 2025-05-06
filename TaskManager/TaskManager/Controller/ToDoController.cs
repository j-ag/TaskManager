using Microsoft.AspNetCore.Mvc;
using TaskManager.Client.DTOs;
using TaskManager.Services.Interfaces;
using AutoMapper;

namespace TaskManager.Controller
{
    [Route("api/[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _toDoService;
        private readonly IMapper _mapper;

        public ToDoController(IToDoService toDoService, IMapper mapper)
        { 
            _toDoService = toDoService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<ToDo> GetToDoItems()
        {
            var toDoItems = _toDoService.Get().ToList();

            List<ToDo> toDoDtoItems = _mapper.Map<List<ToDo>>(toDoItems);

            return toDoDtoItems;
        }
    }
}
