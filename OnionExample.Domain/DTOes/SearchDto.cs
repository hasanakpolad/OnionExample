using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Domain.DTOes
{
    public class SearchDto
    {
        public DateTime RelaseGr { get; set; }
        public DateTime RelaseLess { get; set; }
        public string MovieName { get; set; }
        public string SalloonName { get; set; }
    }
}
