using MyTasks.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyTasks.Test
{
    public class UserTest
    {
        [Fact]
        public void CadastrarUser()
        {
            var user = new User
            {
                Id = '9',
                Email = "isaac@gmail.com",
                Password = "123456"
            };

            Assert.NotEqual(0, user.Id);
            Assert.NotEqual(" ", user.Email);
            Assert.NotEqual(" ", user.Password);
            Assert.NotEqual("$", user.Email);
            Assert.NotEqual("*", user.Email);
            Assert.NotEqual("#", user.Email);
            Assert.NotEqual("+", user.Email);
            Assert.NotEqual("=", user.Email);
            Assert.NotEqual("/", user.Email);
            Assert.NotEqual("[", user.Email);
            Assert.NotEqual(",", user.Email);
            Assert.NotEqual("$", user.Email);
            Assert.NotEqual("!", user.Email);
            Assert.NotNull(user.Email);
            Assert.NotNull(user.Password);














        }
    }
}