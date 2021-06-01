using DataBase;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class AnswersRepository : Repository<Answers, int>, IAnswersRepository
    {
        public AnswersRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
