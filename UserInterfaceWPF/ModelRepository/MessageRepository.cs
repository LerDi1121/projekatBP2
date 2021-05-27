using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    class MessageRepository:Repository<Message,int>,IMessageRepository
    {
        public MessageRepository(DistanceLearningContainer context):base(context)
        {
                
        }
    }
}
