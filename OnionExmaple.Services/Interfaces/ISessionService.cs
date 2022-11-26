using OnionExample.Domain.DTOes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Services.Interfaces
{
    public interface ISessionService
    {
        void Add(AddSessionDto sessionDto);
        void Update(SessionDto sessionDto);
        void Delete(SessionDto sessionDto);
        SessionDto GetSession(int id);
        List<SessionDto> GetAllSession();
    }
}
