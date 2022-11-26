using OnionExample.Domain.DTOes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Services.Interfaces
{
    public interface IMovieService
    {
        void Add(AddMovieDto dto);
        void Update(MovieDto dto);
        void Delete(MovieDto dto);
        MovieDto GetMovie(int id);
        IEnumerable<MovieDto> GetAllMovie();
        IEnumerable<GetSingleMovieDto> GetAllMovieByDto();

        IEnumerable<GetSingleMovieDto> SearchMovie(SearchDto dto);
    }
}
