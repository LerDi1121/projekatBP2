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
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserInterfaceWPF.Controllers;
using UserInterfaceWPF.ModelRepository;
using UserInterfaceWPF.Repository;
using UserInterfaceWPF.TransferModels;

namespace UserInterfaceWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public static User CurrentUser;

        public MainWindow()
        {
            
            InitializeComponent();
         
          

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            errormessage.Text = "";

            if (passwordBox1.Password.Length == 0)
            {
                errormessage.Text = "Enter an password.";
                passwordBox1.Focus();
            }
            if (textBoxUsername.Text.Length == 0)
            {
                errormessage.Text += " Enter an email.";
                textBoxUsername.Focus();
            }
            LoginModel data = new LoginModel()
            {
                username = textBoxUsername.Text,
                password = passwordBox1.Password
            };
            User user = UserController.LogIn(data);
            if(user==null)
                errormessage.Text += " Error";
           
            else if(user.Role == Role.Student)
            {
                CurrentUser = user;
                StudentWindow win = new StudentWindow();
                this.Hide();
                win.Owner = Window.GetWindow(this);
                win.ShowDialog();
       
            }
            else if(user.Role==Role.Teacher)
            {
                CurrentUser = user;
                TeacherWindow win = new TeacherWindow();
                win.Owner = Window.GetWindow(this);
                this.Hide();

                win.ShowDialog();
            }
        }
    }
}
