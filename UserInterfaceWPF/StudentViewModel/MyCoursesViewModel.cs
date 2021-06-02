using DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.Controllers;

namespace UserInterfaceWPF.StudentViewModel
{
    class MyCoursesViewModel :BindableBase
    {
        public static Dictionary<string, Course> AllCourseObj { get; set; } = new Dictionary<string, Course>();
        public string selectedCourse { get; set; }
        public List<string> AllCourse { get; set; } = new List<string>();
        public ObservableCollection<Teaching_topic> AllTopic { get; set; } = new ObservableCollection<Teaching_topic>();
        public MyCoursesViewModel()
        {
           GetCourse();
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
        private void SetTopicForcourse()
        {
            AllTopic.Clear();
            foreach (var t in AllCourseObj[selectedCourse].Teaching_topic)
            {
                AllTopic.Add(t);
            }
            OnPropertyChanged("AllTopic");

         
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
               
                SetTopicForcourse();
            }

        }
    }
}
