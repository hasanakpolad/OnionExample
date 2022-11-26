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
    public class SessionService : ISessionService
    {
        private IUnitOfWork uow;
        private IRepository<MovieSessionsModel> SessionRepository;
        private IMapper mapper;
        public SessionService(IUnitOfWork _uow, IMapper _mapper)
        {
            mapper = _mapper;
            uow = _uow;
            SessionRepository = uow.GetRepository<MovieSessionsModel>();
        }

        public void Add(AddSessionDto sessionDto)
        {
            var entity = mapper.Map<MovieSessionsModel>(sessionDto);
            SessionRepository.Add(entity);
            uow.SaveChanges();
        }

        public void Delete(SessionDto sessionDto)
        {
            var entity = mapper.Map<MovieSessionsModel>(sessionDto);
            SessionRepository.Delete(entity);
            uow.SaveChanges();
        }

        public List<SessionDto> GetAllSession()
        {
            var entity = SessionRepository.GetAll();
            return mapper.Map<List<SessionDto>>(entity);
        }

        public SessionDto GetSession(int id)
        {
            var entity = SessionRepository.Get(id);
            return mapper.Map<SessionDto>(entity);
        }

        public void Update(SessionDto sessionDto)
        {
            var entity = mapper.Map<MovieSessionsModel>(sessionDto);
            SessionRepository.Update(entity);
            uow.SaveChanges();
        }
    }
}
