using System;
using System.Collections.ObjectModel;
using UserInterfaceWPF.Controllers;
using UserInterfaceWPF.TransferModels;

namespace UserInterfaceWPF.TeacherViewModel
{
    public class TestViewModel : BindableBase
    {
        public ObservableCollection<TestForStudentView> AllTests { get; set; } = new ObservableCollection<TestForStudentView>();
        public TestForStudentView selectedTest;
        public MyICommand ReportCommand { get; set; }
        public TestViewModel()
        {
            ReportCommand = new MyICommand( OnReport);

            AllTests = TestController.TestForTeacher();
        }

        private void OnReport()
        {
            TestReport wind = new TestReport(selectedTest.Test);
            wind.ShowDialog();
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
         //       TryTestCommand.RaiseCanExecuteChanged();
            }

        }
    }
}
