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
          //  TryTestCommand = new MyICommand(CanTry, OnTry);

            AllTests = TestController.TestForTeacher();
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
