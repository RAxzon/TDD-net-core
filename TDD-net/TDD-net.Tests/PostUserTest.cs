using System;
using User.Data;
using User.Data.Repository;
using User.Domain.Models;
using Xunit;

namespace TDD_net.Tests
{
    public class PostUserTest : BaseTest
    {
        [Fact]
        public async void Face_PostUser()
        {
            var user = new TDDUser(0,"Richie Axelsson", 37, true);

            user = await new UserRepository(_ctx).Post(user);

            Assert.Equal(1, user.Id);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("ABCD")]
        [InlineData("Richie Axelzzon")]
        public void Theory_PostUser(string name)
        {
            var user = new TDDUser()
            {
                Name = name
            };

            var val = new PostUserValidator().Validate(user);
            Assert.True(val.IsValid);
        }
    }
}
