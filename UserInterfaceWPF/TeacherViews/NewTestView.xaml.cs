using System.Windows.Controls;
using UserInterfaceWPF.TeacherViewModel;

namespace UserInterfaceWPF.TeacherViews
{
    /// <summary>
    /// Interaction logic for NewTestView.xaml
    /// </summary>
    public partial class NewTestView : UserControl
    {
        public NewTestView()
        {
            InitializeComponent();
            this.DataContext = new NewTestViewModel();
        }
    }
}
