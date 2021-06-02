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
using UserInterfaceWPF.TransferModels;

namespace UserInterfaceWPF.StudentViewModel
{
    public class TestViewModel:BindableBase
    {
        public ObservableCollection<TestForStudentView> AllTests { get; set; } = new ObservableCollection<TestForStudentView>();
        public TestForStudentView selectedTest;
        public static int tryTestPoints=-1;
        public static bool tryTestFlag=false;
        public MyICommand TryTestCommand { get; set; }

        public TestViewModel()
        {
            TryTestCommand = new MyICommand(CanTry, OnTry);

            AllTests = TestController.TestForStudent();
        }

        private bool OnTry()
        {
            return selectedTest != null;
        }

        private void CanTry()
        {
            Takes data = new Takes()
            {
                Start_time= DateTime.Now

            };

            UserInterfaceWPF.TryTest wind = new TryTest(SelectedTest.Test);
            wind.ShowDialog();
            MessageBox.Show("Test comleted");
            data.Won_points = tryTestPoints;
            data.Completion_time = DateTime.Now;
            data.Date_of_taking = DateTime.Now;
            data.Test = selectedTest.Test;
            data.Registered = SelectedTest.Reg;
            Mark myMark = TakesController.AddTakesAndGetMark(data);
            MessageBox.Show(myMark.Description_of_mark);
            AllTests = TestController.TestForStudent();
            OnPropertyChanged("AllTests");
        }

        public TestForStudentView SelectedTest
        {
            get
            {
                return selectedTest;
            }
            set
            {
                selectedTest = value;
                TryTestCommand.RaiseCanExecuteChanged();
             }

        }

    }
}
