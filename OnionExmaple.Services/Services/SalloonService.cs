using AutoMapper;
using OnionExample.Application.Interfaces;
using OnionExample.Domain.DTOes;
using OnionExample.Domain.Models;
using OnionExample.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Services.Services
{
    public class SalloonService : ISalloonService
    {
        private IRepository<SalloonModel> SalloonRepository;
        private IUnitOfWork uow;
        IMapper mapper;
        public SalloonService(IUnitOfWork _uow, IMapper _mapper)
        {
            mapper = _mapper;
            uow = _uow;
            SalloonRepository = uow.GetRepository<SalloonModel>();
        }

        public void Add(AddSalloonDto salloonDto)
        {
            var entity = mapper.Map<SalloonModel>(salloonDto);
            SalloonRepository.Add(entity);
            uow.SaveChanges();
        }

        public void Delete(SalloonDto salloonDto)
        {
            var entity = mapper.Map<SalloonModel>(salloonDto);
            SalloonRepository.Delete(entity);
            uow.SaveChanges();
        }

        public IEnumerable<SalloonDto> GetAllSaloon()
        {
            var enitiy = SalloonRepository.GetAll();
            return mapper.Map<IEnumerable<SalloonDto>>(enitiy);
        }

        public SalloonDto GetSaloon(int id)
        {
            var entity = SalloonRepository.Get(id);
            return mapper.Map<SalloonDto>(entity);
        }

        public void Update(SalloonDto salloonDto)
        {
            var entity = mapper.Map<SalloonModel>(salloonDto);
            SalloonRepository.Update(entity);
        }
    }
}
