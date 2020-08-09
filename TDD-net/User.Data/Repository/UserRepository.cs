using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using User.Data.Context;
using User.Domain.Interfaces;
using User.Domain.Models;

namespace User.Data.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly UserContext _ctx;

        public UserRepository(UserContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<TDDUser> Post(TDDUser user)
        {
            await _ctx.Users.AddAsync(user);
            await _ctx.SaveChangesAsync();

            return user;
        }
    }
}
