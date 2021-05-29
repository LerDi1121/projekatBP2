using System;
using System.Collections.Generic;
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
using UserInterfaceWPF.TransferModels;

namespace UserInterfaceWPF
{
    /// <summary>
    /// Interaction logic for NewMessage.xaml
    /// </summary>
    public partial class NewMessage : Window
    {
        public List<string> AllUsername { get; set; } = new List<string>();
       public   string SelectedItem { get; set; }
         public NewMessage()
        {
            GetAllUsername();
            InitializeComponent();
        //    cbSearch.DataContext = AllUsername;

        }

        private void GetAllUsername()
        {
            AllUsername = UserController.getAllUsername().ToList();
        }

        private void cbSearch_Loaded(object sender, RoutedEventArgs e)
        {
            cbSearch.ItemsSource = AllUsername;
            cbSearch.SelectedIndex = 0;
        }

        private void cbSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             SelectedItem = cbSearch.SelectedItem as string;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            Message message = new Message();
            message.Title = tbTitle.Text;
            message.Text = tbText.Text;
            message.Posting_date = DateTime.Now;
            message.User = MainWindow.CurrentUser;
            MessageToSend data = new MessageToSend()
            {
                message = message,
                usernameTo = SelectedItem
            };
            MessageController.SendMesage(data);
        }
    }
}
