using DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UserInterfaceWPF.Controllers;

namespace UserInterfaceWPF.TeacherViewModel
{
    public class NewTestViewModel : BindableBase
    {
        public static Dictionary<string, Course> AllCourseObj { get; set; } = new Dictionary<string, Course>();
        public string SelectedCourse { get; set; }
        public string TbTestName { get; set; }
        public static HashSet<Question> Questions { get; set; } = new HashSet<Question>();
        public List<string> AllCourse { get; set; } = new List<string>();
        private Test test;
        public MyICommand AddTestCommand { get; set; }
        public MyICommand AddQuestionCommand { get; set; }
        public MyICommand DeleteQuestionCommand { get; set; }
        public Question SelectedQuestion { get; set; }
        public ObservableCollection<Question> NewQuestion { get; set; } = new ObservableCollection<Question>();

        public NewTestViewModel()
        {
            DeleteQuestionCommand = new MyICommand(OnDeleteQuestion, CanDeleteQuestion);
            AddTestCommand = new MyICommand(OnAddTest, CanAddTest);
            AddQuestionCommand = new MyICommand(OnAddQuestion,CanAddQuestion);
            GetCourse();
        }

        private bool CanAddQuestion()
        {
            return true;
        }

        private bool CanDeleteQuestion()
        {
            return true;
        }

        private void OnDeleteQuestion()
        {
            int i = 0;
        }

        private void OnAddQuestion()
        {
            Question data = new Question(); 
             NewQuestion wind = new NewQuestion(data);
            wind.ShowDialog();
            NewQuestion.Add(data);
        }

        private bool CanAddTest()
        {
            return true;
        }

        private void OnAddTest()
        {
            int i = 0;
        }

        public void GetCourse()
        {
            HashSet<Course> temp = CourseController.GetAllCourseForTeacher(MainWindow.CurrentUser).ToHashSet();
            foreach (Course c in temp)
            {
                AllCourse.Add(c.Course_name);
                AllCourseObj[c.Course_name] = c;
            }
            OnPropertyChanged("AllCourse");

        }

    }
}
