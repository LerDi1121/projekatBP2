using DataBase;
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
using UserInterfaceWPF.StudentViewModel;

namespace UserInterfaceWPF
{
    /// <summary>
    /// Interaction logic for TryTest.xaml
    /// </summary>
    public partial class TryTest : Window
    {
        List<int> questionNumbers = new List<int>();
        List<Answers> Anslist = new List<Answers>();
        int qNum = 0;
        int i;
        private Test Test;
        private bool flag;
        private int points;
        public TryTest( Test test)
        {
            this.Test = test;
            this.flag = flag;
            this.points = points;
            creteListOfquestionNumbers();

            InitializeComponent();
            NextQuestion();
            TestViewModel.tryTestPoints = -1;
            TestViewModel.tryTestFlag = false;
        }

        void creteListOfquestionNumbers()
        {
            for(int i=0;i<Test.Questions.Count;i++)
            {
                questionNumbers.Add(i);
            }
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();
            questionNumbers = randomList;

        }
        private void NextQuestion()
        {
            List<Question> questions = Test.Questions.ToList();
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                TestViewModel.tryTestPoints = points;
                TestViewModel.tryTestFlag = true;

                this.Close();
            }
            // below we are running a foreach loop where will check for each button inside of the canvas and when we find them 
            //we will set their tag to 0 and background to dakr salmon colour
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }
            txtQuestion.Text = questions[i].Tekst;

            Anslist = questions[i].Answers.ToList();
            var randomList = Anslist.OrderBy(a => Guid.NewGuid()).ToList();
            Anslist = randomList;

            ans1.Content = Anslist[0].Tekst;
            if(Anslist[0].Correct)
                ans1.Tag = "1";

            ans2.Content = Anslist[1].Tekst;
            if (Anslist[1].Correct)
                ans2.Tag = "1";

            ans3.Content = Anslist[2].Tekst;
            if (Anslist[2].Correct)
                ans3.Tag = "1";
            ans4.Content = Anslist[3].Tekst;
            if (Anslist[3].Correct)
                ans4.Tag = "1";

         

        }
        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            List<Question> questions = Test.Questions.ToList();
            Button senderButton = sender as Button; 
              if (senderButton.Tag.ToString() == "1")
            {
                points += questions[i].Total_points;
            }

            // if the qnum is less than 0 then we will reset the qnum integer to 0
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                // if the qnum is greater than 0 then we will add 1 to the qnum integer
                qNum++;
            }

             // run the next question function*/
            NextQuestion();

        }

    }
}
