using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    class TakesRepository:Repository<Takes, int>, ITakesRepository
    {
        public TakesRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
