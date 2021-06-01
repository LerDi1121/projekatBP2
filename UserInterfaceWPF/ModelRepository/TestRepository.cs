using DataBase;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class TestRepository : Repository<Test, int>, ITestRepository
    {
        public TestRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
