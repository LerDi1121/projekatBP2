using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UserInterfaceWPF
{
    /// <summary>
    /// Interaction logic for NewQuestion.xaml
    /// </summary>
    public partial class NewQuestion : Window
    {
        public List<string> QuestionLevel { get; set; } = new List<string>() { DataBase.QuestionLevel.Low.ToString(), DataBase.QuestionLevel.Middle.ToString(), DataBase.QuestionLevel.High.ToString() };
        public string SelectedItem { get; set; }
        Question dataToReturn;
        public NewQuestion( Question dataToReturn)
        {
           this.dataToReturn = dataToReturn;
            InitializeComponent();
            cbQLevel.ItemsSource = QuestionLevel;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateData())
                return;
           CreateQuestion();
            MessageBox.Show("question are created");
            this.Close();
            

        }

        private void CreateQuestion()
        {
            int points = int.Parse(NumberTextBox.Text);

            this.dataToReturn.Tekst = tbText.Text;
            this.dataToReturn.Level = GetQuestionLevel(cbQLevel.SelectedItem.ToString());
            this.dataToReturn.Total_points = points;
            
            string tempStr = SelectedItem;
            Answers CorAnswer = new Answers()
            {
                Tekst = tbCA.Text,
                Correct = true,
                Question = this.dataToReturn
            };
            Answers WrongAnswer1 = new Answers()
            {
                Tekst = tbWA1.Text,
                Correct = false,
                Question = this.dataToReturn
            };
            Answers WrongAnswer2 = new Answers()
            {
                Tekst = tbWA2.Text,
                Correct = false,
                Question = this.dataToReturn
            };
            Answers WrongAnswer3 = new Answers()
            {
                Tekst = tbWA3.Text,
                Correct = false,
                Question = this.dataToReturn
            };
            this.dataToReturn.Answers.Add(CorAnswer);
            this.dataToReturn.Answers.Add(WrongAnswer1);
            this.dataToReturn.Answers.Add(WrongAnswer2);
            this.dataToReturn.Answers.Add(WrongAnswer3);
            
        

            
        }
        private QuestionLevel GetQuestionLevel(string data)
        {
            switch (data)
            {
                case "Low":
                    return DataBase.QuestionLevel.Low ;
                case "Middle":
                    return DataBase.QuestionLevel.Middle;
                case "High":
                    return DataBase.QuestionLevel.High;
                default:
                    return  DataBase.QuestionLevel.High;
               
            }
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private bool ValidateData()
        {
            if (tbCA.Text == null && tbCA.Text== string.Empty)
                return false;
            if (tbWA1.Text == null && tbWA1.Text == string.Empty)
                return false;
            if (tbWA2.Text == null && tbWA2.Text == string.Empty)
                return false;
            if (tbWA3.Text == null && tbWA3.Text == string.Empty)
                return false; 

            if (tbText.Text == null && tbText.Text == string.Empty)
                return false;

            if (NumberTextBox.Text == null && NumberTextBox.Text == string.Empty)
                return false;

            if (SelectedItem == null && SelectedItem == string.Empty)
                return false;
            return true;

        }
    }
}
