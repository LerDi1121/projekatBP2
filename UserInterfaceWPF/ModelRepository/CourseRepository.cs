using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    class CourseRepository:Repository<Course,int>, ICourseRepository
    {
        public CourseRepository(DistanceLearningContainer context ):base(context)
        {

        }
    }
}
