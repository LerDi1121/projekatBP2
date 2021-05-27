using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    class Teaching_topicRepository:Repository<Teaching_topic,int>, ITeaching_topicRepository
    {
        public Teaching_topicRepository(DistanceLearningContainer context ):base(context)
        {

        }
    }
}
