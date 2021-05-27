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
using UserInterfaceWPF.Repository;

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
            var initTeach = new Teacher()
            {
                Username = "Nastavniik1",
                Surname = "birovljv",
                Name = "vlada",
                Role = Role.Teacher,
                eMail = "neki@Mail",
                Password = "vlada123",
                Title = "dip inz racunarstva i automatike",
                Proession = "Nastavnik informatike"
            };
            UnitOfWork repo = new UnitOfWork(container);
            repo.TeacherRepository.Add(initTeach);
            repo.TeacherRepository.Save();
            ;
        }
    }
}
