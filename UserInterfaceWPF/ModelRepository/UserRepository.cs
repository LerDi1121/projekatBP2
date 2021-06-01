using DataBase;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class UserRepository : Repository<User, int>, IUserRepository
    {
        public UserRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
