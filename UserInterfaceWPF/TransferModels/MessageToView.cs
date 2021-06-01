using DataBase;
using System.ComponentModel;

namespace UserInterfaceWPF.TransferModels
{
    public class MessageToView : INotifyPropertyChanged
    {
        private string from;
        private string to;
        private string title;
        public Message Message;

        public string To
        {
            get => to;
            set
            {
                if (this.to != value)
                {
                    this.to = value;
                    RaisePropertyChanged("To");
                }
            }
        }
        public string Title
        {
            get => title;
            set
            {
                if (this.title != value)
                {
                    this.title = value;
                    RaisePropertyChanged("Title");
                }
            }
        }
        public string From
        {
            get => from;
            set
            {
                if (this.from != value)
                {
                    this.from = value;
                    RaisePropertyChanged("From");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}
