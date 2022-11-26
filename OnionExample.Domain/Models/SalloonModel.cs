using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Domain.Models
{
    public class SalloonModel
    {
        public int Id { get; set; }
        public string SalloonName { get; set; }

        public List<MovieSessionsModel> MovieSessionsModels { get; set; }

        public int MovieModelId { get; set; }
        public MovieModel MovieModel { get; set; }
    }
}
