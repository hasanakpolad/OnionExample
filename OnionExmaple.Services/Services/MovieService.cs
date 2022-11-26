using AutoMapper;
using OnionExample.Application.Interfaces;
using OnionExample.Domain.DTOes;
using OnionExample.Domain.Models;
using OnionExample.Services.Interfaces;

namespace OnionExample.Services.Services
{
    public class MovieService : IMovieService
    {
        private IUnitOfWork uow;
        private IRepository<MovieModel> MovieRepository;
        private IMapper mapper;
        public MovieService(IUnitOfWork _uow, IMapper _mapper)
        {
            uow = _uow;
            mapper = _mapper;
            MovieRepository = uow.GetRepository<MovieModel>();
        }

        public void Add(AddMovieDto dto)
        {
            var entity = mapper.Map<MovieModel>(dto);
            MovieRepository.Add(entity);
            uow.SaveChanges();
        }

        public void Update(MovieDto dto)
        {
            var entity = mapper.Map<MovieModel>(dto);
            MovieRepository.Update(entity);
            uow.SaveChanges();
        }

        public void Delete(MovieDto dto)
        {
            var entity = MovieRepository.Get(dto.Id);
            MovieRepository.Delete(entity);
            uow.SaveChanges();
        }

        public MovieDto GetMovie(int id)
        {
            var entity = MovieRepository.Get(x => x.Id.Equals(id));
            return mapper.Map<MovieDto>(entity);
        }

        public IEnumerable<MovieDto> GetAllMovie()
        {
            var entities = MovieRepository.GetAll();
            return mapper.Map<IEnumerable<MovieDto>>(entities);
        }

        public IEnumerable<GetSingleMovieDto> GetAllMovieByDto()
        {
            var entities = MovieRepository.GetAll()
                .Select(m => new GetSingleMovieDto()
                {
                    Id = m.Id,
                    MovieName = m.MovieName,
                    Salloons = m.Salloons.Select(s => new SalloonDto()
                    {
                        Id = s.Id,
                        SalloonName = s.SalloonName,
                        MovieSessionsModels = mapper.Map<IEnumerable<SessionDto>>(s.MovieSessionsModels)

                    })
                });
            return entities;
        }
    }
}
