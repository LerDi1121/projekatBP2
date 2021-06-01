using DataBase;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class MarkRepository : Repository<Mark, int>, IMarkRepository
    {
        public MarkRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
