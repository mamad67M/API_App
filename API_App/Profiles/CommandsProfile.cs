using API_App.DTOs;
using API_App.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_App.Profiles
{
    public class CommandsProfile: Profile
    {
        public CommandsProfile()
        {
           // source -> target
            CreateMap<Command, CommandReadDTO>();
            CreateMap<CommandCreateDTO, Command>();
        }
    }
}
