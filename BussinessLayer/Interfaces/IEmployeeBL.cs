using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    public interface IEmployeeBL<TEntity>
    {
        public IEnumerable<Employee> GetAll();
    }
}
