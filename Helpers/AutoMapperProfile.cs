using AutoMapper;
using jm_web_api.Entities;
using jm_web_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jm_web_api.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        { 
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
/*
The automapper profile contains the mapping configuration used by the application, 
AutoMapper is a package available on Nuget that enables automatic mapping
of one type of classes to another. In this example we're using 
it to map between User entities and a few different model types 
- UserModel, RegisterModel and UpdateModel.
         
*/
    }
}
