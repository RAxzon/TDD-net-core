using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using User.Data.Context;

namespace TDD_net.Tests
{
    public class BaseTest
    {
        protected UserContext _ctx;

        public BaseTest(UserContext ctx = null)
        {
            _ctx = ctx ?? GetInMemoryDBContext();
        }

        protected UserContext GetInMemoryDBContext()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<UserContext>();
            var options = builder.UseInMemoryDatabase("test").UseInternalServiceProvider(serviceProvider).Options;

            UserContext userContext = new UserContext(options);
            userContext.Database.EnsureDeleted();
            userContext.Database.EnsureCreated();

            return userContext;
        }
    }
}
