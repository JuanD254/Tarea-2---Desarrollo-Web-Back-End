using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tarea_2___Desarrollo_Web_Back_End.DataAccess;

namespace Tarea_2___Desarrollo_Web_Back_End.BackEnd
{
    public class EmployeeSC
    {
        NorthwindContext dataContext = new NorthwindContext();
        public IQueryable<Employee> GetEmployees()
        {
            var queryEmp = dataContext.Employees.Select(e => e).AsQueryable();
            return queryEmp;
        }

    }
}
