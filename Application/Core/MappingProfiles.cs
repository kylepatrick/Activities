using System;
using Domain;
using AutoMapper;
using Application.Activites.DTOs;

namespace Application.Core;

public class MappingProfiles : Profile
{

    public MappingProfiles()
    {
        CreateMap<Activity, Activity>();
        CreateMap<CreateActivityDto,Activity>();

}



}