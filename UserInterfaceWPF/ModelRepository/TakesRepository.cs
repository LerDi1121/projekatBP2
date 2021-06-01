using DataBase;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class TakesRepository : Repository<Takes, int>, ITakesRepository
    {
        public TakesRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
