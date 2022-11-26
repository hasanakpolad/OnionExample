using AutoMapper;
using OnionExample.Domain.DTOes;
using OnionExample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Application.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<AddMovieDto, MovieModel>();
            CreateMap<MovieModel, MovieDto>();

            CreateMap<AddSalloonDto, SalloonModel>();
            CreateMap<SalloonModel, SalloonDto>();

            CreateMap<AddSessionDto, MovieSessionsModel>();
            CreateMap<MovieSessionsModel, SessionDto>();

            //CreateMap<List<MovieSessionsModel>, IEnumerable<SessionDto>>();
        }
    }
}
