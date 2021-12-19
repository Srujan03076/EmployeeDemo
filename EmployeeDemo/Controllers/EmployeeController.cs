﻿using BussinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly IEmployeeBL<Employee> bl;
        public EmployeeController(IEmployeeBL<Employee> bl)
        {
            this.bl = bl;
        }

        [HttpGet]
        public ActionResult GetAllEmployee()
        {
            var data = this.bl.GetAll();
            return Ok(new { Sucess = true, message = "GetAll Sucessfully performed", Data = data });
        }

    }
}
