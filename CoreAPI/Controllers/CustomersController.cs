using System;
using System.Collections.Generic;
using CoreAPI.Data;
using CoreAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CustomersController: ControllerBase
    {
        private readonly ICustomerRepo _data;

        public CustomersController(ICustomerRepo command)
        {
            _data = command;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllApps()
        {
            var result = _data.GetAllCustomers();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetCommandById(int Id)
        {
            var result = _data.GetCustomerId(1);

            return Ok(result);
        }
    }
}
