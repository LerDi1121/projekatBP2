using DataBase;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepositoryInterface
{
    interface IMessageRepository : IRepository<Message, int>
    {
    }
}
