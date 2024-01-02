using AutoMapper;
using DataAccess.Identity.Model;
using Entity.DTOs;
using Entity.Entities;
using Entity.IUnitOfWork;
using Entity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

		public async Task<string> UpdateCommand(CommandDto commandDto)
        {
            try
            {
                var oldCommand = await _uow.GetRepository<Command>().Get(x => x.Id == commandDto.Id);
                oldCommand.Content = commandDto.Content;
                await _uow.CommitAsync();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<List<CommandDto>> GetAllByFilter(Expression<Func<Command, bool>> filter = null, Func<IQueryable<Command>, IOrderedQueryable<Command>> orderby = null, params Expression<Func<Command, object>>[] includes)
        {
            try
            {
                var list = await _uow.GetRepository<Command>().GetAll(filter, orderby, includes);
                var mappedList = _mapper.Map<List<CommandDto>>(list);
                if (mappedList.Count() > 0)
                {
                    foreach (var item in mappedList)
                    {
                        var user = await _uow.GetRepository<AppUser>().Get(x => x.Id == item.UserId);
                        item.User = _mapper.Map<UserDto>(user);
                    }
                }
                return mappedList;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
