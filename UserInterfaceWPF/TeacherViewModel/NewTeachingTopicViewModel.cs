using DataBase;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using UserInterfaceWPF.Controllers;

namespace UserInterfaceWPF.TeacherViewModel
{
    public class NewTeachingTopicViewModel : BindableBase
    {
        public List<string> AllCourse { get; set; } = new List<string>();
        public List<Course> AllCoursesObj { get; set; } = new List<Course>();

        public string SelectedItem { get; set; }
        public MyICommand SaveCommand { get; set; }
        public string tbTitle { get; set; }
        public NewTeachingTopicViewModel()
        {
            SaveCommand = new MyICommand(OnSend, CanSend);
            GetTopic();
        }
        public void GetTopic()
        {
            AllCoursesObj = CourseController.GetAllCourseForTeacher(MainWindow.CurrentUser).ToList();
            AllCourse = AllCoursesObj.Select(c => c.Course_name).ToList();
        }
        private Course getCourseBuyName(string name)
        {
            foreach (var c in AllCoursesObj)
            {
                if (c.Course_name == name)
                    return c;
            }
            return null;
        }

        public string TbTitle
        {
            get
            {
                return tbTitle;
            }
            set
            {
                if (tbTitle != value)
                {
                    tbTitle = value;
                    OnPropertyChanged("TbTitle");
                    SaveCommand.RaiseCanExecuteChanged();
                }
            }
        }
        private bool CanSend()
        {
            if (TbTitle == string.Empty || tbTitle == string.Empty)
                return false;
            else if (TbTitle == null || tbTitle == null)
                return false;
            return true;
        }
        private int GetMaxSerialForCourse(Course data)
        {
            int retVal = 0;
            foreach (var tt in data.Teaching_topic)
            {
                if (tt.Serial_number > retVal)
                    retVal = tt.Serial_number;
            }
            return retVal;
        }

        private void OnSend()
        {
            Course tempCourse = getCourseBuyName(SelectedItem);
            int index = GetMaxSerialForCourse(tempCourse);
            var topic = new Teaching_topic()
            {
                Topic_name = tbTitle,
                Course = tempCourse,

            };
            TeachingTopicController.AddTeachingTopic(topic);
            MessageBox.Show("Successful");
        }
    }
}
