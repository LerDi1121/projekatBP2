using DataBase;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepositoryInterface
{
    public interface IUserRepository : IRepository<User, int>
    {
    }

}
