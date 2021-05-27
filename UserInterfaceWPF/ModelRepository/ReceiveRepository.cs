using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    class ReceiveRepository:Repository<Receive,int>, IReceiveRepository
    {
        public ReceiveRepository(DistanceLearningContainer context):base (context)
        {
                
        }
    }
}
