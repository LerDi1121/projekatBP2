using DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using UserInterfaceWPF.Controllers;

namespace UserInterfaceWPF.TeacherViewModel
{
    public class NewTestViewModel : BindableBase
    {
        public static Dictionary<string, Course> AllCourseObj { get; set; } = new Dictionary<string, Course>();
        public string selectedCourse { get; set; }
        public string TbTestName { get; set; }
        public static HashSet<Question> Questions { get; set; } = new HashSet<Question>();
        public List<string> AllCourse { get; set; } = new List<string>();
        private Test test;
        public MyICommand AddTestCommand { get; set; }
        public MyICommand AddQuestionCommand { get; set; }
        public MyICommand DeleteQuestionCommand { get; set; }
        public Question selectedQuestion { get; set; }
        public ObservableCollection<Question> NewQuestions { get; set; } = new ObservableCollection<Question>();

        public NewTestViewModel()
        {
            DeleteQuestionCommand = new MyICommand(OnDeleteQuestion, CanDeleteQuestion);
            AddTestCommand = new MyICommand(OnAddTest, CanAddTest);
            AddQuestionCommand = new MyICommand(OnAddQuestion,CanAddQuestion);
            GetCourse();
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
                AddQuestionCommand.RaiseCanExecuteChanged();
               
            }

        }

        public Question SelectedQuestion {
            get
            {
                return selectedQuestion;
            }
            set
            {
                selectedQuestion = value;
                DeleteQuestionCommand.RaiseCanExecuteChanged();
                // SetTopicForcourse();
            }
        }

        private bool CanAddQuestion()
        {
            return selectedCourse!=null;
        }

        private bool CanDeleteQuestion()
        {
            return selectedQuestion!=null;
        }

        private void OnDeleteQuestion()
        {
            NewQuestions.Remove(selectedQuestion);
            OnPropertyChanged("NewQuestions");
        }

        private void OnAddQuestion()
        {
            Question data = new Question(); 
             NewQuestion wind = new NewQuestion(data);
            wind.ShowDialog();
            NewQuestions.Add(data);
            AddTestCommand.RaiseCanExecuteChanged();
        }

        private bool CanAddTest()
        {
            return NewQuestions.Count>=2&&(TbTestName!=null &&TbTestName!=string.Empty);
        }

        private void OnAddTest()
        {
            int pointsForTest = 0;
            foreach (var q in NewQuestions)
            {
                pointsForTest += q.Total_points;
            }
            var testForAdding = new Test()
            {
                Test_Name = TbTestName,
                Points=pointsForTest,
                Course =AllCourseObj[selectedCourse],
                Questions= NewQuestions

            };
            TestController.AddTest(testForAdding);
            MessageBox.Show("Successful");
           
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
