using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Domain.Models
{
    public class MovieSessionsModel
    {
        public int Id { get; set; }
        public DateTime MovieSessionStart { get; set; }
        public DateTime MovieSessionExpire { get; set; }

        public int SalloonModelId { get; set; }
        public SalloonModel SalloonModel { get; set; }
    }
}
