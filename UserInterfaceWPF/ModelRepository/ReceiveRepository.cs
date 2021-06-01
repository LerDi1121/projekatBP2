using DataBase;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class ReceiveRepository : Repository<Receive, int>, IReceiveRepository
    {
        public ReceiveRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
