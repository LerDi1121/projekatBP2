using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceWPF.Controllers
{
    public static class RegisteredController
    {
        public static bool RegisteredStudentOnCourse(Course data)
        {
            var Student = (Student)MainWindow.CurrentUser;
            var AllRegistration = MainWindow.UnitOfWork_.RegisteredRepository.GetAll().Where(R => R.Course.Id_Course == data.Id_Course && R.Student.Id_Student == Student.Id_Student).ToHashSet();
         if(AllRegistration.Count==0)
            {
                Registered newReg = new Registered()
                {
                    Application_date = DateTime.Now,
                    Course = data,
                    Student=Student

                };
                MainWindow.UnitOfWork_.RegisteredRepository.Add(newReg);
                MainWindow.UnitOfWork_.RegisteredRepository.Save();

                return true;
            }
            else
            {
                return false;
            }
                    
        }
        public static ICollection<Registered> GetAllRegistrationForStudent()
        {
            var student = (Student)MainWindow.CurrentUser;
            return MainWindow.UnitOfWork_.RegisteredRepository.GetAll().Where(r => r.Student.Id_Student == student.Id_Student).ToList();
        }
        
    }
}
