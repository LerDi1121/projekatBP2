using DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UserInterfaceWPF.Controllers;

namespace UserInterfaceWPF
{
    /// <summary>
    /// Interaction logic for TestReport.xaml
    /// </summary>
    public partial class TestReport : Window
    {
        public ObservableCollection<UserInterfaceWPF.TransferModels.TestReport> AllReports { get; set; } 

        public TestReport( Test data)
        {
            DataContext = this;
            InitializeComponent();
            AllReports = TestController.CreateReportsForTest(data);
            datagrid.ItemsSource = AllReports;
        }
    }
}
