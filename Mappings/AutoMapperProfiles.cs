﻿using AutoMapper;
using FirstRestfulAPI.Model.Domain;
using FirstRestfulAPI.Model.DTO;

namespace FirstRestfulAPI.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();

            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            
            CreateMap<UpdateRegionRequestDto, Region>().ReverseMap();

            CreateMap<Walk, WalkDto>().ReverseMap();

            CreateMap<AddWalkRequestDto, Walk>().ReverseMap();

            CreateMap<Difficulty, DifficultyDto>().ReverseMap();

            CreateMap<UpdateWalkRequestDto, Walk>().ReverseMap();

        }
    }
}
