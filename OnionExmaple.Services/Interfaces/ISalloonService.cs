using OnionExample.Domain.DTOes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Services.Interfaces
{
    public interface ISalloonService
    {
        void Add(AddSalloonDto salloonDto);
        void Update(SalloonDto salloonDto);
        void Delete(SalloonDto salloonDto);
        SalloonDto GetSaloon(int id);
        IEnumerable<SalloonDto> GetAllSaloon();
    }
}
