using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface ICommandService
    {
        Task<string> AddCommand(CommandDto commandDto);
    }
}
