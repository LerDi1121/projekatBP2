using DataBase;
using System.Collections.Generic;
using System.Linq;

namespace UserInterfaceWPF.Controllers
{
    public static class CourseController
    {
        public static void AddCourse(Course data)
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
        public static ICollection<Course> GetAllCourse()
        {
            HashSet<Course> retval = new HashSet<Course>();
            HashSet<Course> temp = new HashSet<Course>();
            temp = MainWindow.UnitOfWork_.CourseRepository.GetAll().ToHashSet();
        
            return temp;
        }
        public static ICollection<Course> GetAllCourseForStudent(User data)
        {
            HashSet<Course> retval = new HashSet<Course>();
            HashSet<Registered> temp = new HashSet<Registered>();
            temp = MainWindow.UnitOfWork_.RegisteredRepository.GetAll().Where(r=>r.Student.Id_User==data.Id_User).ToHashSet();
            foreach(var r in temp)
            { retval.Add(r.Course); }
            return retval;
        }

        public static void DeleteCourse(Course data)
        {
            //izbrisati veze
          /*  foreach (var reg in data.Registereds)
            {
                //  MainWindow.UnitOfWork_.CourseRepository.Remove(data);
                  foreach( var takes in reg.Takes)
                    {
                        MainWindow.UnitOfWork_.TakesRepository.Remove(takes);
                        MainWindow.UnitOfWork_.TakesRepository.Save();
                    }
                MainWindow.UnitOfWork_.RegisteredRepository.Remove(reg);
                MainWindow.UnitOfWork_.RegisteredRepository.Save();
            }
            foreach (var tt in data.Teaching_topic)
            {
                //  MainWindow.UnitOfWork_.CourseRepository.Remove(data);

                MainWindow.UnitOfWork_.Teaching_topicRepository.Remove(tt);
                MainWindow.UnitOfWork_.Teaching_topicRepository.Save();

            }
            foreach (var test in data.Tests)
            {
                ///  MainWindow.UnitOfWork_.CourseRepository.Remove(data);
                 foreach (var takes in test.Takes)
                 {
                     MainWindow.UnitOfWork_.TakesRepository.Remove(takes);
                     MainWindow.UnitOfWork_.TakesRepository.Save();
                 }
                
                MainWindow.UnitOfWork_.TestRepository.Remove(test);
                MainWindow.UnitOfWork_.TestRepository.Save();

            }
            MainWindow.UnitOfWork_.CourseRepository.Remove(data);
            MainWindow.UnitOfWork_.CourseRepository.Save();*/
        }

    }
}
