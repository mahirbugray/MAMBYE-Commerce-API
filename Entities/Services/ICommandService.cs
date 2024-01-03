using Entity.DTOs;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface ICommandService
    {
        Task<string> AddCommand(CommandDto commandDto);
        Task<string> UpdateCommand(CommandDto commandDto);
        Task<List<CommandDto>> GetAllByFilter(Expression<Func<Command, bool>> filter = null, Func<IQueryable<Command>, IOrderedQueryable<Command>> orderby = null, params Expression<Func<Command, object>>[] includes);
    }
}
