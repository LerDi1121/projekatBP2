using System.Windows.Controls;
using UserInterfaceWPF.TeacherViewModel;

namespace UserInterfaceWPF.TeacherViews
{
    /// <summary>
    /// Interaction logic for CourseView.xaml
    /// </summary>
    public partial class CourseView : UserControl
    {
        public CourseView()
        {
            InitializeComponent();
            this.DataContext = new CourseViewModel();
        }
    }
}
