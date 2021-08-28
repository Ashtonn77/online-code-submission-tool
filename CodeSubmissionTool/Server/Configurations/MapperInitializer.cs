using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CodeSubmissionTool.Server.Models;
using CodeSubmissionTool.Shared;

namespace CodeSubmissionTool.Server.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Test, TestDto>().ReverseMap();
        }

    }
}
