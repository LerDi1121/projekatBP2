using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.StudentViewModel;
using UserInterfaceWPF.TeacherViewModel;

namespace UserInterfaceWPF
{
   public   class StudentWindowViewModel:BindableBase
    {
        public MyICommand<string> NavCommand { get; private set; }

        public BindableBase currentViewModel;
        private CoursesViewModel CoursesViewModel = new CoursesViewModel();
        private MyCoursesViewModel MyCoursesViewModel = new MyCoursesViewModel();
        private StudentViewModel.TestViewModel TestViewModel = new StudentViewModel.TestViewModel();
        private TestHistoryViewModel TestHistoryViewModel = new TestHistoryViewModel();
        public StudentWindowViewModel()
        {
            NavCommand = new MyICommand<String>(OnNav);
            CurrentViewModel = CoursesViewModel;

        }

        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "Courses":
                    CurrentViewModel = CoursesViewModel;
                    break;
                case "MyCourse":
                    CurrentViewModel = MyCoursesViewModel;
                    break;
               case "Tests":
                    CurrentViewModel = TestViewModel;
                    break;
                case "TestHistory":
                    CurrentViewModel = TestHistoryViewModel;
                    break;
               /* case "NewMessage":
                    CurrentViewModel = NewMessageViewModel;
                    break;
                case "NewCourse":
                    CurrentViewModel = NewCourseViewModel;
                    break;
                case "TeachingTopic":
                    CurrentViewModel = newTeachingTopicViewModel;
                    break;
                case "NewTest":
                    CurrentViewModel = newTestViewModel;
                    break;*/

            }
        }

        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                SetProperty(ref currentViewModel, value);
            }
        }
    }
}
