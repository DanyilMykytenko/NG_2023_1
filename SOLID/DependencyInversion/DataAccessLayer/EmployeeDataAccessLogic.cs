using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.DataAccessLayer
{
    public class EmployeeDataAccessLogic
    {
        public Employee GetEmployeeDetails(int id)
        {
            var employee = new Employee()
            {
                Id = id,
                Name = "FIKUS"
            };
            return employee;
        }
    }
}
