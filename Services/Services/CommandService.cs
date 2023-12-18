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

        public async Task<string> DeleteCommand(int id)
        {
            try
            {
                _uow.GetRepository<Command>().DeleteById(id);
                await _uow.CommitAsync();
                return "OK";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public async Task<string> UpdateCommand(CommandDto commandDto)
        {
            try
            {
                var oldCommand = await _uow.GetRepository<Command>().Get(x => x.Id == commandDto.Id);
                oldCommand.Content = commandDto.Content;
                oldCommand.Point = commandDto.Point;
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
