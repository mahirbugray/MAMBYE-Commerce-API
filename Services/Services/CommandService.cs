using AutoMapper;
using Entity.DTOs;
using Entity.Entities;
using Entity.IUnitOfWork;
using Entity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CommandService : ICommandService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CommandService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<string> AddCommand(CommandDto commandDto)
        {
            try
            {
                var commandEntity = _mapper.Map<Command>(commandDto);
                await _uow.GetRepository<Command>().Add(commandEntity);
                await _uow.CommitAsync();
                return "OK";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
