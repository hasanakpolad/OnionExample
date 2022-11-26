using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Domain.DTOes
{
    public class AddSingleMovieDto
    {
        public AddMovieDto MovieDto { get; set; }
        public AddSalloonDto SalloonDto { get; set; }
        public AddSessionDto SessionDto { get; set; }
    }
}
