﻿using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using AutoMapper;

namespace FilmesApi.Profiles;

public class FilmeProfile: Profile
{
    public FilmeProfile() 
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();
    }
}
