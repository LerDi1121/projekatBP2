using DataBase;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class TeacherRepository : Repository<Teacher, int>, ITeacherRpository
    {
        public TeacherRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
