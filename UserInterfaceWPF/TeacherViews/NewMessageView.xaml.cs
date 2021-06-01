using System.Windows.Controls;
using UserInterfaceWPF.TeacherViewModel;

namespace UserInterfaceWPF.TeacherViews
{
    /// <summary>
    /// Interaction logic for NewMessage.xaml
    /// </summary>
    public partial class NewMessageView : UserControl
    {
        public NewMessageView()
        {
            InitializeComponent();
            this.DataContext = new NewMessageViewModel();
        }
    }
}
