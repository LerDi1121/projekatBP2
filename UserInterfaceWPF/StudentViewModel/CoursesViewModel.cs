using DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UserInterfaceWPF.Controllers;
using UserInterfaceWPF.TeacherViewModel;

namespace UserInterfaceWPF.StudentViewModel
{
    class CoursesViewModel:BindableBase
    {
        public static Dictionary<string, Course> AllCourseObj { get; set; } = new Dictionary<string, Course>();
        public string selectedCourse { get; set; }
        public List<string> AllCourse { get; set; } = new List<string>();
        public ObservableCollection<Teaching_topic> AllTopic { get; set; } = new ObservableCollection<Teaching_topic>();
        public MyICommand RegOnCourseCommand { get; set; }
        public CoursesViewModel()
        {
            RegOnCourseCommand = new MyICommand(OnRegCourse, CanRegCourse);
            GetCourse();
        }

        private bool CanRegCourse()
        {
            return selectedCourse != null;
        }

        private void OnRegCourse()
        {
            Course course = AllCourseObj[selectedCourse];
            if (RegisteredController.RegisteredStudentOnCourse(course))
                MessageBox.Show("Successfully registered");
            else
                MessageBox.Show("You are already registered");

        }
        public void GetCourse()
        {
            HashSet<Course> temp = CourseController.GetAllCourseForStudent(MainWindow.CurrentUser).ToHashSet();
            foreach (Course c in temp)
            {
                AllCourse.Add(c.Course_name);
                AllCourseObj[c.Course_name] = c;
            }
            OnPropertyChanged("AllCourse");

        }
        public string SelectedCourse
        {
            get
            {
                return selectedCourse;
            }
            set
            {
                selectedCourse = value;
                RegOnCourseCommand.RaiseCanExecuteChanged();
                SetTopicForcourse();
            }

        }
        private void SetTopicForcourse()
        {
            AllTopic.Clear();
            foreach (var t in AllCourseObj[selectedCourse].Teaching_topic)
            {
                AllTopic.Add(t);
            }
            OnPropertyChanged("AllTopic");

            // = AllCourseObj[selectedCourse].Teaching_topic;
        }
    }
}
