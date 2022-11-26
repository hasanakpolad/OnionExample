using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Domain.DTOes
{
    public class SalloonDto
    {
        public int Id { get; set; }
        public string SalloonName { get; set; }

        public IEnumerable<SessionDto> MovieSessionsModels { get; set; }
    }
}
