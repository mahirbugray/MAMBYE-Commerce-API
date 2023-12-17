using AutoMapper;
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
    }
}
