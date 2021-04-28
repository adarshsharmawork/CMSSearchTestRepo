using System;
using System.Collections.Generic;
using CoreAPI.Data;
using CoreAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CommandsController: ControllerBase
    {
        private readonly ICommandRepo _data;

        public CommandsController(ICommandRepo command)
        {
            _data = command;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllApps()
        {
            var result = _data.GetAllApps();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int Id)
        {
            var result = _data.GetById(1);

            return Ok(result);
        }
    }
}
