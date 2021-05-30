using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
