using System;
using System.Collections.Generic;
using CoreAPI.Models;

namespace CoreAPI.Data
{
    public class MockData : ICommandRepo
    {
        public IEnumerable<Command> GetAllApps()
        {
            List<Command> result =new List<Command>();

            for (int i = 0; i < 3; i++)
            {
                Command command = new Command();
                command.Id = i;
                command.HowTo = "Same again" + i;
                command.Line = "Lineno" + i;
                command.Platform = "Platoform No" + i;
                result.Add(command);
            }
            return result;
        }

        public Command GetById(int Id)
        {
            return new Command { Id = 0, HowTo = "Using Pan", Line = "great", Platform = "Gas" };
        }
    }
}
