using OnionExample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Domain.DTOes
{
    public class GetSingleMovieDto
    {
        public int Id { get; set; }
        public string MovieName { get; set; }

        public IEnumerable<SalloonDto> Salloons { get; set; }

    }
}
