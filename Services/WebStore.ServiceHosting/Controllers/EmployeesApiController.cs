using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domian.Models;
using WebStore.Interfaces.Services;

namespace WebStore.ServiceHosting.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/employees")]
    [ApiController]
    public class EmployeesApiController : ControllerBase, IEmployeesData
    {
        private readonly IEmployeesData _EmployeesData;

        public EmployeesApiController(IEmployeesData EmployeesData) => _EmployeesData = EmployeesData;

        [HttpPost]
        public void Add([FromBody] Employee Employee) => _EmployeesData.Add(Employee);

        [HttpDelete("{id}")]
        public bool Delete(int id) => _EmployeesData.Delete(id);

        [HttpPut("{id}")]
        public void Edit(int id,[FromBody] Employee Employee) => _EmployeesData.Edit(id, Employee);

        [HttpGet]
        public IEnumerable<Employee> GetAll() => _EmployeesData.GetAll();

        [HttpGet("{id}")]
        public Employee GetById(int id) => _EmployeesData.GetById(id);

        public void SaveChanges() => _EmployeesData.SaveChanges();
    }
}