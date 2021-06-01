using System.Windows.Controls;
using UserInterfaceWPF.TeacherViewModel;

namespace UserInterfaceWPF.TeacherViews
{
    /// <summary>
    /// Interaction logic for TestView.xaml
    /// </summary>
    public partial class TestView : UserControl
    {
        public TestView()
        {
            InitializeComponent();
            this.DataContext = new TestViewModel();
        }
    }
}
