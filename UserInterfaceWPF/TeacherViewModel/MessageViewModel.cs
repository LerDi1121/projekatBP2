using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceWPF.TeacherViewModel
{
    public class MessageViewModel : BindableBase
    {
        public MyICommand DeleteCommand { get; set; }
        private Message selectedMessage;
        public static ObservableCollection<Message> Message { get; set; } = new ObservableCollection<Message>();
        public MessageViewModel()
        {
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
        }
        private bool CanDelete()
        {
            return SelectedMessage != null;
        }
        private void OnDelete()
        {
          //  Vodomeri.Remove(SelectedVodomer);
        }
        public Message SelectedMessage
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
