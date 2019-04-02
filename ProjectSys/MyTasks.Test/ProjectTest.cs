using MyTasks.Models;
using System;
using Xunit;

namespace MyTasks.Test
{
    public class ProjectTest
    {
        [Fact]
        public void CadastrarProject()
        {
            var project = new Project
            {

                UserId = '9',
                Title = "Projeto 2019"
            };
          
            Assert.NotEqual(0, project.UserId);
            Assert.NotEqual(" ", project.Title);

        }
    }
}
