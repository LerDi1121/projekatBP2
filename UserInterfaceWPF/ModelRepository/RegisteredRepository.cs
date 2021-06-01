using DataBase;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class RegisteredRepository : Repository<Registered, int>, IRegisteredRepository
    {
        public RegisteredRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
