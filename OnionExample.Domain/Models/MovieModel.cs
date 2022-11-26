using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Domain.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public DateTime MovieReleaseDate { get; set; }

        public List<SalloonModel> Salloons { get; set; }
    }
}
