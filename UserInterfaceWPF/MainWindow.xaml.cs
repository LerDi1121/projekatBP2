using DataBase;
using System.Windows;
using UserInterfaceWPF.Controllers;
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
        public static UnitOfWork UnitOfWork_ = new UnitOfWork();

        public MainWindow()
        {

            InitializeComponent();

           /* var temp = new Teacher()
            {
                Id_User=10,
                Id_Teacher=10,
                Title = "inz",
                Proession = "prof",
                Username = "rof",
                Surname = "Surname",
                Name = "Name",
                Role = Role.Teacher,
                eMail = "email",
                Password = "prof"

            };
            var tempStud = new Student()
            {
                Id_User = 11,
                Id_Student=11,
                Username = "stud",
                Surname = "Surname",
                Name = "Name",
                Role = Role.Student,
                eMail = "email",
                Password = "stud",
                Class="psi"
            };
           
            MainWindow.UnitOfWork_.StudentRepository.Add(tempStud);
            MainWindow.UnitOfWork_.StudentRepository.Save();

           MainWindow.UnitOfWork_.TeacherRepository.Add(temp);
            MainWindow.UnitOfWork_.TeacherRepository.Save();*/

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
            if (user == null)
                errormessage.Text += " Error";

            else if (user.Role == Role.Student)
            {
                CurrentUser = user;
                StudentWindow win = new StudentWindow();
                this.Hide();
                win.Owner = Window.GetWindow(this);
                win.ShowDialog();

            }
            else if (user.Role == Role.Teacher)
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
