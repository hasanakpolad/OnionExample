using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Domain.DTOes
{
    public class SessionDto
    {
        public int Id { get; set; }
        public DateTime MovieSessionStart { get; set; }
        public DateTime MovieSessionExpire { get; set; }
    }
}
