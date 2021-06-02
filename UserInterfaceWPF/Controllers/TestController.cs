using DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.TransferModels;

namespace UserInterfaceWPF.Controllers
{
    public static class TestController
    {
        public static void AddTest(Test data)
        {
            MainWindow.UnitOfWork_.TestRepository.Add(data);
            MainWindow.UnitOfWork_.TestRepository.Save();

        }
        public static ObservableCollection<TestForStudentView> TestForTeacher()
        {
           

            ObservableCollection<TestForStudentView> retval = new ObservableCollection<TestForStudentView>();
            Teacher me = (Teacher)MainWindow.CurrentUser;
            foreach(var c in me.Courses)
            {
                foreach (var t in c.Tests)
                {
                    retval.Add(new TestForStudentView()
                    {
                        TestName=t.Test_Name,
                        testPoints=t.Points,
                        courseName=c.Course_name,
                        questionNumber=t.Questions.Count(),
                        Test=t
                        
                    });
                }

                
            }
            /*foreach (var r in StudentsRegistration)
            {
                var tests = GetTestForCourse(r.Course);
                foreach (var t in tests)
                {
                    bool flag = true;
                    foreach (var takes in r.Takes)
                    {
                        if (takes.Test.Id_Test == t.Id_Test)
                            flag = false;
                    }
                    if (flag)
                        retval.Add(new TestForStudentView()
                        {
                            TestName = t.Test_Name,
                            TestPoints = t.Points,
                            CourseName = r.Course.Course_name,
                            Test = t,
                            QuestionNumber = t.Questions.Count,
                            Reg = r
                        });
                }

            }*/
            return retval;
        }
        public static ObservableCollection<TestForStudentView> TestForStudent()
        {
            var StudentsRegistration = RegisteredController.GetAllRegistrationForStudent();
            
           
            ObservableCollection<TestForStudentView> retval = new ObservableCollection<TestForStudentView>();
            foreach(var r in StudentsRegistration)
            {
                var tests = GetTestForCourse(r.Course);
                foreach(var t in tests)
                {
                    bool flag = true;
                    foreach(var takes in r.Takes)
                    {
                        if (takes.Test.Id_Test == t.Id_Test)
                            flag = false;
                    }
                    if(flag)
                        retval.Add(new TestForStudentView()
                        {
                            TestName = t.Test_Name,
                            TestPoints = t.Points,
                            CourseName = r.Course.Course_name,
                            Test = t,
                            QuestionNumber=t.Questions.Count,
                            Reg=r
                        });
                }
    
            }
            return retval;
        }
        public static ICollection<Test> GetTestForCourse(Course  course)
        {
            return MainWindow.UnitOfWork_.TestRepository.GetAll().Where(T => T.Course.Id_Course == course.Id_Course).ToHashSet();
        }

       
        public static ObservableCollection<TestHistory> TestHistoryForStudent()
        {
           
            //  Takes var;
            ObservableCollection<TestHistory> retval = new ObservableCollection<TestHistory>();
            var StudentsRegistration = RegisteredController.GetAllRegistrationForStudent();
            foreach (var r in StudentsRegistration)
            {
               foreach(var t in r.Takes)
                {
                    retval.Add(new TestHistory()
                    {
                        TestName=t.Test.Test_Name,
                        testPoints=t.Test.Points,
                        courseName=r.Course.Course_name,
                        MarkDescription=t.Marks.Description_of_mark,
                        MarkValue=t.Marks.Value_of_Mark
                    });
                }

            }
            return retval;
        }
        static public ObservableCollection<UserInterfaceWPF.TransferModels.TestReport> CreateReportsForTest(Test data)
        {
          
            ObservableCollection<TransferModels.TestReport> retval = new ObservableCollection<TransferModels.TestReport>();
            foreach(var take in data.Takes)
            {
               retval.Add( new TransferModels.TestReport()
                {
                    Username = take.Registered.Student.Username,
                    NameSurname = take.Registered.Student.Name + " " + take.Registered.Student.Surname,
                    Test = data.Test_Name,
                    Course = data.Course.Course_name,
                    MaxPoints = data.Points,
                    Points = take.Won_points,
                    MarkValue = take.Marks.Value_of_Mark,
                    MarkDesc = take.Marks.Description_of_mark

                });
              

            }
            return retval;
        }

    }
}
