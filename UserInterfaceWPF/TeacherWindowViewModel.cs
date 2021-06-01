using System;
using UserInterfaceWPF.TeacherViewModel;

namespace UserInterfaceWPF
{
    public class TeacherWindowViewModel : BindableBase
    {
        public MyICommand<string> NavCommand { get; private set; }

        public BindableBase currentViewModel;

        private CourseViewModel CourseViewModel = new CourseViewModel();
        private TestViewModel TestViewModel = new TestViewModel();
        private MessageViewModel MessageViewModel = new MessageViewModel();
        private ProfileViewModel ProfileViewModel = new ProfileViewModel();
        private NewMessageViewModel NewMessageViewModel = new NewMessageViewModel();
        private NewCourseViewModel NewCourseViewModel = new NewCourseViewModel();
        private NewTeachingTopicViewModel newTeachingTopicViewModel = new NewTeachingTopicViewModel();
        private NewTestViewModel newTestViewModel = new NewTestViewModel();
        public TeacherWindowViewModel()
        {

            NavCommand = new MyICommand<String>(OnNav);
            currentViewModel = CourseViewModel;

        }
        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                SetProperty(ref currentViewModel, value);
            }
        }
        private void OnNav(string destination)
        {
            switch (destination)
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

            }
        }
    }
}
