using DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UserInterfaceWPF.Controllers;

namespace UserInterfaceWPF.TeacherViewModel
{
    public class CourseViewModel: BindableBase
    {
        public static Dictionary<string, Course> AllCourseObj { get; set; } = new Dictionary<string, Course>();
        public string selectedCourse { get; set; }
        public List<string> AllCourse { get; set; } = new List<string>();
       public  ObservableCollection<Teaching_topic> AllTopic { get; set; } = new ObservableCollection<Teaching_topic>();
        private Teaching_topic selectedTopic { get; set; }

        public MyICommand DeleteCourseCommand { get; set; }
        public MyICommand DeleteTopicCommand { get; set; }
        public CourseViewModel()
        {
            DeleteCourseCommand = new MyICommand(OnDeleteCourse, CanDeleteCourse);
            DeleteTopicCommand = new MyICommand(OnDeleteTopic, CanDeleteTopic);
            GetCourse();
        }

        private bool CanDeleteTopic()
        {
            return selectedTopic != null;
        }

        private bool CanDeleteCourse()
        {
            return SelectedCourse != null;
        }

        private void OnDeleteCourse()
        {
            CourseController.DeleteCourse(AllCourseObj[selectedCourse]);
            GetCourse();
        }
        private void OnDeleteTopic()
        {
            TeachingTopicController.DeleteTopic(selectedTopic);
            GetCourse();
            SetTopicForcourse();
            MessageBox.Show("Topic deleted");
        }
        public Teaching_topic  SelectedTopic {
            get
            {
                return selectedTopic;
            }
            set
            {
                selectedTopic = value;
                DeleteTopicCommand.RaiseCanExecuteChanged();
               // SetTopicForcourse();
            }
        }
        public void GetCourse()
        {
            HashSet<Course> temp = CourseController.GetAllCourseForTeacher(MainWindow.CurrentUser).ToHashSet();
            foreach(Course c in temp)
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
                DeleteCourseCommand.RaiseCanExecuteChanged();
                SetTopicForcourse();
            }

        }
        private void SetTopicForcourse()
        {
            AllTopic.Clear();
            foreach(var t in AllCourseObj[selectedCourse].Teaching_topic)
            {
                AllTopic.Add(t);
            }
            OnPropertyChanged("AllTopic");

            // = AllCourseObj[selectedCourse].Teaching_topic;
        }

    }
}
