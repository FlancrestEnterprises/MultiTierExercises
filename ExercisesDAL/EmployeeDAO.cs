using System;
using MongoDB.Driver.Linq;
using System.Linq;


namespace ExercisesDAL
{
   public class EmployeeDAO
    {


        public EmployeeDAO() { }

        public Employee GetEmployeeBySurname(string name)
        {

            Employee retEmp = null;
            DbContext _ctx;
            try
            {
                _ctx = new DbContext();
                var employees = _ctx.Employees;
                var employee = employees.AsQueryable<Employee>().FirstOrDefault(emp => emp.Lastname == name);
                retEmp = (Employee)employee;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Problem " + ex.Message);

            }

            return retEmp;
        }
    }
}
