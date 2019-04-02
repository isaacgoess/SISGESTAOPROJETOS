using MyTasks.Models;
using System;
using Xunit;

namespace MyTasks.Test
{
    public class TaskTest
    {
        [Fact]
        public void CadastrarTask()
        {
            var task = new Task
            {

                Id = '9',
                Title = "Projeto 2019"
            };

            Assert.NotEqual(0, task.Id);
            Assert.NotEqual(" ", task.Title);
            Assert.NotNull(task.Title);



        }

    }
}