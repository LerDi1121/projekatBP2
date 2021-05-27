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
using UserInterfaceWPF.ModelRepository;

namespace UserInterfaceWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DistanceLearningContainer container = new DistanceLearningContainer();
            InitializeComponent();
            var initUser = new User()
            {
                Username = "proba",
                Surname = "probaPrezime",
                Name = "proba ime",
                Role = Role.Student,
                eMail = "neki@Mail",
                Password = "prona123"
            };
            UserRepository repo = new UserRepository(container);
            repo.Add(initUser);
            repo.Save();
        }
    }
}
