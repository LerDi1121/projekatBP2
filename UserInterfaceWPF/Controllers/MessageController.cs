using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.Repository;
using UserInterfaceWPF.TransferModels;

namespace UserInterfaceWPF.Controllers
{
    static class MessageController
    {
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
    }
}
