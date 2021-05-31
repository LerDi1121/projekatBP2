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
    }
}
