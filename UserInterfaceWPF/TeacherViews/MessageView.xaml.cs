using System.Windows;
using System.Windows.Controls;
using UserInterfaceWPF.TeacherViewModel;

namespace UserInterfaceWPF.TeacherViews
{
    /// <summary>
    /// Interaction logic for MessageView.xaml
    /// </summary>
    public partial class MessageView : UserControl
    {
        public MessageView()
        {
            InitializeComponent();
            this.DataContext = new MessageViewModel();
        }

        private void btnNewMesage_Click(object sender, RoutedEventArgs e)
        {
            /* NewMessage newMess = new NewMessage();
             newMess.Show();*/

        }
    }
}
