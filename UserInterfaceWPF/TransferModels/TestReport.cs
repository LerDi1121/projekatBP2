using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceWPF.TransferModels
{
   public  class TestReport
    {
        string username;
        string nameSurname;
        string test;
        string course;
        int maxPoints;
        int points;
        int markValue;
        string markDesc;
        public int MaxPoints
        {
            get => maxPoints;
            set
            {
                if (this.maxPoints != value)
                {
                    this.maxPoints = value;
                    RaisePropertyChanged("MaxPoints");
                }
            }
        }
        public int Points
        {
            get => points;
            set
            {
                if (this.points != value)
                {
                    this.points = value;
                    RaisePropertyChanged("Points");
                }
            }
        }
        public int MarkValue
        {
            get => markValue;
            set
            {
                if (this.markValue != value)
                {
                    this.markValue = value;
                    RaisePropertyChanged("MarkValue");
                }
            }
        }
        public string MarkDesc
        {
            get => markDesc;
            set
            {
                if (this.markDesc != value)
                {
                    this.markDesc = value;
                    RaisePropertyChanged("MarkDesc");
                }
            }
        }
        public string Course
        {
            get => course;
            set
            {
                if (this.course != value)
                {
                    this.course = value;
                    RaisePropertyChanged("Course");
                }
            }
        }
        public string Test
        {
            get => test;
            set
            {
                if (this.test != value)
                {
                    this.test = value;
                    RaisePropertyChanged("Test");
                }
            }
        }
        public string NameSurname
        {
            get => nameSurname;
            set
            {
                if (this.nameSurname != value)
                {
                    this.nameSurname = value;
                    RaisePropertyChanged("NameSurname");
                }
            }
        }
        public string Username
        {
            get => username;
            set
            {
                if (this.username != value)
                {
                    this.username = value;
                    RaisePropertyChanged("Username");
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
