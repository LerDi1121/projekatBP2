using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.Controllers;
using UserInterfaceWPF.TransferModels;

namespace UserInterfaceWPF.StudentViewModel
{
    class TestHistoryViewModel:BindableBase
    {
        public ObservableCollection<TestHistory> AllTests { get; set; } = new ObservableCollection<TestHistory>();
        public TestHistoryViewModel()
        {
            AllTests = TestController.TestHistoryForStudent();
        }
    }
}
