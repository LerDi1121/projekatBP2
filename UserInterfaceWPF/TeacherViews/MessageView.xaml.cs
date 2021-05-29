﻿using System;
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
            NewMessage newMess = new NewMessage();
            newMess.Show();

        }
    }
}
