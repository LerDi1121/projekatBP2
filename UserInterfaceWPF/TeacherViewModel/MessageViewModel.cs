using System.Collections.ObjectModel;
using UserInterfaceWPF.Controllers;
using UserInterfaceWPF.TransferModels;

namespace UserInterfaceWPF.TeacherViewModel
{
    public class MessageViewModel : BindableBase
    {
        public MyICommand DeleteCommand { get; set; }
        public MyICommand ToMeCommand { get; set; }
        public MyICommand FromMeCommand { get; set; }
        public MyICommand AllMessageCommand { get; set; }
        //AllMessageCommand

        private MessageToView selectedMessage;
        public static ObservableCollection<MessageToView> Message { get; set; } = new ObservableCollection<MessageToView>();
        public MessageViewModel()
        {
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            ToMeCommand = new MyICommand(GetMessToMe);
            FromMeCommand = new MyICommand(GetMessFromMe);
            AllMessageCommand = new MyICommand(GetAllMessage);
            GetAllMessage();
            OnPropertyChanged("Message");

        }
        private bool CanDelete()
        {
            return SelectedMessage != null;
        }
        private void GetMessFromMe()
        {

            Message = MessageController.GetMessFromMe(MainWindow.CurrentUser);
            OnPropertyChanged("Message");

        }
        private void GetMessToMe()
        {

            Message = MessageController.GetMessToMe(MainWindow.CurrentUser);
            OnPropertyChanged("Message");


        }
        private void GetAllMessage()
        {

            Message = MessageController.GetAllMessageForUser(MainWindow.CurrentUser);
            OnPropertyChanged("Message");

        }
        private void OnDelete()
        {
            if (selectedMessage != null)
                MessageController.DeleteMessage(selectedMessage.Message);
        }
        public MessageToView SelectedMessage
        {
            get
            {
                return selectedMessage;
            }
            set
            {
                selectedMessage = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }

        }
    }
}
