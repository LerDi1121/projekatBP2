using DataBase;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class MessageRepository : Repository<Message, int>, IMessageRepository
    {
        public MessageRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
