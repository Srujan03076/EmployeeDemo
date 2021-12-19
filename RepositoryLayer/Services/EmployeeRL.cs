using RepositoryLayer.Context;
using RepositoryLayer.Entities;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Services
{
    public class EmployeeRL : IEmployeeRL<Employee>
    {
        readonly EmployeeContext context;
        public EmployeeRL(EmployeeContext context)
        {
            this.context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return this.context.Employees.ToList();
        }
    }
}
