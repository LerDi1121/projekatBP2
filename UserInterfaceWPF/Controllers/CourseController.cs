using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceWPF.Controllers
{
   public static class CourseController
    {
       public static void AddCourse(Course data )
        {
            MainWindow.UnitOfWork_.CourseRepository.Add(data);
            MainWindow.UnitOfWork_.CourseRepository.Save();
        }
        public static ICollection<Course> GetAllCourseForTeacher(User data)
        {
            HashSet<Course> retval = new HashSet<Course>();
            retval = MainWindow.UnitOfWork_.CourseRepository.GetAll().Where(c => c.Teacher.Id_User == data.Id_User).ToHashSet();
            return retval;
        }
    }
}
