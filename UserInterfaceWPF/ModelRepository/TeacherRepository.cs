using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    class TeacherRepository : Repository<Teacher, int>, ITeacherRpository
    {
        public TeacherRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
