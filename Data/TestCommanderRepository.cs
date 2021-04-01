using FirstWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Data
{
    public class TestCommanderRepository : ICommanderRepository
    {
        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void DeteleCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>()
            {
                new Command { Id = 0, HowTo = "How to_0", Line = "Lie_0", Platform = "Platform_0" },
                new Command { Id = 1, HowTo = "How to_1", Line = "Lie_1", Platform = "Platform_2" },
                new Command { Id = 2, HowTo = "How to_2", Line = "Lie_2", Platform = "Platform_3" },

            };

            return commands;

        }

        public Command GetCommandById(int id)
        {

            return new Command { Id = 0, HowTo = "How to_0", Line = "Lie_0", Platform = "Platform_0" };

        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
