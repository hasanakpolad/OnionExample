using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Services.Interfaces
{
    public interface ISalloonService
    {
        void Add();
        void Update();
        void Delete();
        string GetSaloon();
        List<string> GetAllSaloon();
    }
}
