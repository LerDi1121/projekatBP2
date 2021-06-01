using DataBase;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class CourseRepository : Repository<Course, int>, ICourseRepository
    {
        public CourseRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
