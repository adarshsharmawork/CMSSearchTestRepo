using System;
using System.Collections.Generic;
using CoreAPI.Models;

namespace CoreAPI.Data
{
    public interface ICommandRepo
    {
        IEnumerable<Command> GetAllApps();
        Command GetById(int Id);
    }
}
