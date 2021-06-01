using DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.Repository;
using UserInterfaceWPF.TransferModels;

namespace UserInterfaceWPF.Controllers
{
    static class MessageController
    {
      //  static private DateTime DefDate_of_deletion = new DateTime(2000, 1, 1, 1, 1, 1);
        //static private DateTime DefDate_of_reading = new DateTime(2000, 1, 1, 1, 1, 1);
        public static ObservableCollection<MessageToView> GetMessFromMe(User user)
        {
            ObservableCollection<MessageToView> retVal = new ObservableCollection<MessageToView>();
            ICollection<Message> temp = MainWindow.UnitOfWork_.MessageRepository.GetAll().Where(m=>m.User.Id_User==user.Id_User). ToHashSet();
            foreach(var m in temp)
            {
                ObservableCollection<MessageToView> temp2 = CreateMessageFromMeView(m);
                if (temp2.Count > 0)
                {
                    foreach (var t in temp2)
                    {
                        retVal.Add(t);
                    }
                }
                   
            }
            
            return retVal;
        }
        public static ObservableCollection<MessageToView> GetMessToMe(User user)
        {
            ObservableCollection<MessageToView> retVal = new ObservableCollection<MessageToView>();
            ICollection<Message> temp = MainWindow.UnitOfWork_.MessageRepository.GetAll() .ToHashSet();
            foreach(var m in temp)
            {
                foreach(var r in m.Receives)
                {
                    if(r.Users.Id_User==user.Id_User)
                    {
                        retVal.Add(CreateMessageToMeoView(r));

                    }
                }
               
                  //  retVal.Add(m);
            }

            return retVal;
        }
        public static ObservableCollection<MessageToView> GetAllMessageForUser(User user)
        {
            ObservableCollection<MessageToView> retVal = new ObservableCollection<MessageToView>();
            ICollection<Message> temp = MainWindow.UnitOfWork_.MessageRepository.GetAll().ToHashSet();
            foreach (var m in temp)
            {
               if(m.User.Id_User==user.Id_User)//ako je on posalo por, kome je sve poslao 
                {
                    ObservableCollection<MessageToView> temp2 = CreateMessageFromMeView(m);
                    if (temp2.Count > 0)
                        foreach(var t in temp2)
                        {
                            retVal.Add(t);
                        }
             
                }
                else {// ako je primio poruku
                   
                    foreach (var r in m.Receives)
                    {
                        if (r.Users.Id_User == user.Id_User)
                        {
                            retVal.Add(CreateMessageToMeoView(r));
                          //  break;

                        }
                    }
                }
               
            }

            return retVal;
        }
        public static  void SendMesage(MessageToSend data)
        {
           
            var toUser = UserController.getUserByUsername(data.usernameTo);
            var receive = new Receive()
            {
                Messages = data.message,
                Users = toUser,
                Date_of_deletion = new DateTime(2000, 1, 1, 1, 1, 1),
                Date_of_reading= new DateTime(2000, 1, 1, 1, 1, 1),

        };
            HashSet<int> idList = MainWindow.UnitOfWork_.MessageRepository.GetAll().Select(m => m.Id_Message).ToHashSet();
            int maxId;

            if (idList.Count == 0)
                maxId = 0;
            else
                 maxId = idList.Max();

            data.message.Id_Message = maxId+1;
            MainWindow.UnitOfWork_.MessageRepository.Add(data.message);
            
            
            receive.Messages = data.message;
            MainWindow.UnitOfWork_.ReceiveRepository.Add(receive);
            MainWindow.UnitOfWork_.ReceiveRepository.Save();
            

        }
        static private ObservableCollection< MessageToView> CreateMessageFromMeView( Message data)
        {
            ObservableCollection<MessageToView> retVal = new ObservableCollection<MessageToView>();
            foreach(var rec in data.Receives)
            { 
                var temp = new MessageToView()
                {
                  From=  data.User.Username,
                  To=rec.Users.Username,
                  Title=data.Title,
                  Message=data
                  
                };
                retVal.Add(temp);

            }
            return retVal;
        }
        static private MessageToView CreateMessageToMeoView( Receive data)
        {
            var retVal = new MessageToView()
            {
                From = data.Users.Username,//ko je poslao "meni"
                To = data.Messages.User.Username,//"meni"
                Title = data.Messages.Title,
                Message = data.Messages
            };
            return retVal;

        }
        static public void  DeleteMessage( Message data)
        {
            //nesto
        }
    }
}
