using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Service.Interfaces
{
    public interface IMovieService
    {
        void Add();
        void Update();
        void Delete();
        string GetMovie();
        List<string> GetAllMovie();
    }
}
