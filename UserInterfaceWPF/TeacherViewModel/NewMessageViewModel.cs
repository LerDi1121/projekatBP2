using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.Controllers;
using UserInterfaceWPF.TransferModels;

namespace UserInterfaceWPF.TeacherViewModel
{
    class NewMessageViewModel:BindableBase
    {
        public List<string> AllUsername { get; set; } = new List<string>();
        public string SelectedItem { get; set; }
        public MyICommand AddCommand { get; set; }
        public string tbText { get; set; }
        public string tbTitle { get; set; }
        public NewMessageViewModel()
        {
            AllUsername = UserController.getAllUsername().ToList() ;
            AddCommand = new MyICommand(OnSend,CanSend);
        }
        public string TbText
        {
            get
            {
                return tbText;
            }
            set
            {
                if (tbText != value)
                {
                    tbText = value;
                    OnPropertyChanged("IdText");
                    AddCommand.RaiseCanExecuteChanged();
                }
            }
        }
        public string TbTitle
        {
            get
            {
                return tbTitle;
            }
            set
            {
                if (tbTitle != value)
                {
                    tbTitle = value;
                    OnPropertyChanged("IdText");
                    AddCommand.RaiseCanExecuteChanged();
                }
            }
        }
        public  bool CanSend()
        {
            if (tbText == string.Empty || tbTitle == string.Empty)
                return false;
            else if (tbText == null || tbTitle == null)
                return false;
            return true;

        }
        public void OnSend()
        {
            Message message = new Message();
            message.Title = tbTitle;
            message.Text = tbText;
            message.Posting_date = DateTime.Now;
            message.User = MainWindow.CurrentUser;
            MessageToSend data = new MessageToSend()
            {
                message = message,
                usernameTo = SelectedItem
            };
            MessageController.SendMesage(data);
        }
    }
}
