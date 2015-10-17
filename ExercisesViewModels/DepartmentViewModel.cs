using System;
using ExercisesDAL;
namespace ExercisesViewModels
{
   public class DepartmentViewModel
    {
        private DepartmentDAO _dao;

        public string DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        //constructor
        public DepartmentViewModel()
        {

            _dao = new DepartmentDAO();

        }

        //find dept from dal
        public void GetById()
        {

            try
            {
                Department dept = _dao.GetById(DepartmentId);

                DepartmentId = dept._id.ToString();
                DepartmentName = dept.DepartmentName;
            }
            catch (Exception ex)
            {
                DepartmentId = "not found";
            }


        }


    }


}