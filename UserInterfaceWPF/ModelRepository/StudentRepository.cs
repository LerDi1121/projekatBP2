using DataBase;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class StudentRepository : Repository<Student, int>, IStudentRepository
    {
        public StudentRepository(DistanceLearningContainer context) : base(context)
        {

        }
    }
}
