using AutoMapper;
using Models;
using System;
using TaskManager.Client.DTOs;

namespace TaskManager.Mappings
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<ToDos, ToDo>();
        }
    }
}
