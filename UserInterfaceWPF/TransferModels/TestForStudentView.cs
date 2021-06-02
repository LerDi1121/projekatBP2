using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceWPF.TransferModels
{
    public class TestForStudentView
    {
        public string testName { get; set; }
        public int testPoints { get; set; }
        public string courseName { get; set; }

        public int questionNumber;
        public Test Test { get; set; }
        public Registered Reg { get; set; }

        public int QuestionNumber
        {
            get => questionNumber;
            set
            {
                if (this.questionNumber != value)
                {
                    this.questionNumber = value;
                    RaisePropertyChanged("QuestionNumber");
                }
            }
        }
        public int TestPoints
        {
            get => testPoints;
            set
            {
                if (this.testPoints != value)
                {
                    this.testPoints = value;
                    RaisePropertyChanged("TestPoints");
                }
            }
        }
        public string TestName
        {
            get => testName;
            set
            {
                if (this.testName != value)
                {
                    this.testName = value;
                    RaisePropertyChanged("TestName");
                }
            }
        }

        public string CourseName
        {
            get => courseName;
            set
            {
                if (this.courseName != value)
                {
                    this.courseName = value;
                    RaisePropertyChanged("CourseName");
                }
            }
        }

        internal event PropertyChangedEventHandler PropertyChanged;
        internal void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
