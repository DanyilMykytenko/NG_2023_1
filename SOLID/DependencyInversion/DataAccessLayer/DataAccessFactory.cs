using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.DataAccessLayer
{
    public static class DataAccessFactory
    {
        public static EmployeeDataAccessLogic GetEmployeeDataAccessLogic()
        {
            return new EmployeeDataAccessLogic();
        }
    }
}
