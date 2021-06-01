using System.Windows.Controls;
using UserInterfaceWPF.TeacherViewModel;

namespace UserInterfaceWPF.TeacherViews
{
    /// <summary>
    /// Interaction logic for NewTeachingTopicView.xaml
    /// </summary>
    public partial class NewTeachingTopicView : UserControl
    {
        public NewTeachingTopicView()
        {
            InitializeComponent();
            this.DataContext = new NewTeachingTopicViewModel();
        }
    }
}
