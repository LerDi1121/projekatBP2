using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.TeacherViewModel;

namespace UserInterfaceWPF
{
   public  class TeacherWindowViewModel: BindableBase
    {
        public MyICommand<string> NavCommand { get; private set; }

        public BindableBase currentViewModel;

        private CourseViewModel CourseViewModel = new CourseViewModel();
        private TestViewModel TestViewModel = new TestViewModel();
        private MessageViewModel MessageViewModel = new MessageViewModel();
        private ProfileViewModel ProfileViewModel = new ProfileViewModel();
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

            }
        }
    }
}
