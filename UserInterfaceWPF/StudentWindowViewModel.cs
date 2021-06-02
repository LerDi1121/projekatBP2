using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.TeacherViewModel;

namespace UserInterfaceWPF
{
   public   class StudentWindowViewModel:BindableBase
    {
        public MyICommand<string> NavCommand { get; private set; }

        public BindableBase currentViewModel;
        public StudentWindowViewModel()
        {
            NavCommand = new MyICommand<String>(OnNav);

        }

        private void OnNav(string destination)
        {
            /*switch (destination)
            {
                case "Course":
                    CurrentViewModel = CourseViewModel;
                    break;
                case "Test":
                    CurrentViewModel = TestViewModel;
                    break;
                case "Message":
                    CurrentViewModel = MessageViewModel;
                    break;
                case "Profile":
                    CurrentViewModel = ProfileViewModel;
                    break;
                case "NewMessage":
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
                    break;

            }*/
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
