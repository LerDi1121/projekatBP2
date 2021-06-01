using DataBase;
using System.Collections.Generic;
using UserInterfaceWPF.Controllers;

namespace UserInterfaceWPF.TeacherViewModel
{
    class NewCourseViewModel : BindableBase
    {
        public string SelectedItem { get; set; }
        public MyICommand SaveCommand { get; set; }
        public string tbName { get; set; }

        public List<string> CourseStatus { get; set; } = new List<string>() { DataBase.CourseStatus.Active.ToString(), DataBase.CourseStatus.Inactive.ToString(), DataBase.CourseStatus.InPreparation.ToString() };
        public NewCourseViewModel()
        {
            SaveCommand = new MyICommand(OnSave, CanSave);

        }
        public string TbName
        {
            get
            {
                return tbName;
            }
            set
            {
                if (tbName != value)
                {
                    tbName = value;
                    OnPropertyChanged("TbName");
                    SaveCommand.RaiseCanExecuteChanged();
                }
            }
        }
        private DataBase.CourseStatus FindStatus(string data)
        {
            DataBase.CourseStatus retVal = DataBase.CourseStatus.Active;
            switch (data)
            {
                case "Active":
                    retVal = DataBase.CourseStatus.Active;
                    break;
                case "Inactive":
                    retVal = DataBase.CourseStatus.Inactive;
                    break;
                case "InPreparation":
                    retVal = DataBase.CourseStatus.InPreparation;
                    break;


            }
            return retVal;
        }
        private void OnSave()
        {
            var course = new Course()
            {
                Course_name = tbName,
                Teacher = MainWindow.CurrentUser as Teacher,
                Course_status = FindStatus(SelectedItem)

            };
            CourseController.AddCourse(course);
        }

        private bool CanSave()
        {
            if (tbName == string.Empty || SelectedItem == string.Empty)
                return false;
            else if (tbName == null || SelectedItem == null)
                return false;
            return true;
        }
    }
}
