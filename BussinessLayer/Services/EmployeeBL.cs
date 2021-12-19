using RepositoryLayer.Entities;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Services
{
    public class EmployeeBL : Interfaces.IEmployeeBL<Employee>
    {
        private IEmployeeRL<Employee> employeeRL;

        public EmployeeBL(IEmployeeRL<Employee> employeeRL)
        {
            this.employeeRL = employeeRL;
        }

        public IEnumerable<Employee> GetAll()
        {
            return this.employeeRL.GetAll();
        }
    }
}
