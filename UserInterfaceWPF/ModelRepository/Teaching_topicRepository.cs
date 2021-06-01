using DataBase;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class Teaching_topicRepository : Repository<Teaching_topic, int>, ITeaching_topicRepository
    {
        public Teaching_topicRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
