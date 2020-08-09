using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Models;

namespace User.Domain.Interfaces
{
    public interface IUserRepository
    {
        public Task<TDDUser> Post(TDDUser user);
    }
}
