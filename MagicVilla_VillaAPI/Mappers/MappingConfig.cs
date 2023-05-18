﻿using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dtos;

namespace MagicVilla_VillaAPI.Mappers
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>()
                .ReverseMap();
            CreateMap<Villa, VillaCreateDTO>()
                .ReverseMap() ;
            CreateMap<Villa, VillaUpdateDTO>()
                .ReverseMap();

            CreateMap<VillaNumber,VillaNumberDTO>()
                .ReverseMap();
            CreateMap<VillaNumber, VillaNumberCreateDTO>()
               .ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdateDTO>()
               .ReverseMap();
            CreateMap<ApplicationUser, UserDTO>()
                .ReverseMap();
        }
    }
}
