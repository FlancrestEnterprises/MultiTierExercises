using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExercisesDAL;
using ExercisesViewModels;

namespace ExercisesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void EmployeeDAOReturnBySurnamShouldReturnEmployee()
        {
            EmployeeDAO dao = new EmployeeDAO();
            Employee someEmployee = dao.GetEmployeeBySurname("Smartypants");
            Assert.IsInstanceOfType(someEmployee, typeof(Employee));

        }
        [TestMethod]

        public void EmployeeViewModelReturnBySurnameShouldLoadFirstname()
        {
            EmployeeViewModel vm = new EmployeeViewModel();
            vm.Lastname = "Smartypants";
            vm.GetBySurname();
            Assert.IsTrue(vm.Firstname.Length > 0);

        }



    }
}
