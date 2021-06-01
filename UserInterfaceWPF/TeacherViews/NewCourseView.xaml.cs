using System.Windows.Controls;
using UserInterfaceWPF.TeacherViewModel;

namespace UserInterfaceWPF.TeacherViews
{
    /// <summary>
    /// Interaction logic for NewCourseView.xaml
    /// </summary>
    public partial class NewCourseView : UserControl
    {
        public NewCourseView()
        {
            InitializeComponent();
            this.DataContext = new NewCourseViewModel();
        }
    }
}
