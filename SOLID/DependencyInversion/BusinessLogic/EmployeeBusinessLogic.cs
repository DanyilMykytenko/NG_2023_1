using DependencyInversion.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.BusinessLogic
{
    public class EmployeeBusinessLogic
    {
        private readonly EmployeeDataAccessLogic _employeeDataAccessLogic;
        public EmployeeBusinessLogic()
        {
            _employeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessLogic();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _employeeDataAccessLogic.GetEmployeeDetails(id);
        }
    }
}
