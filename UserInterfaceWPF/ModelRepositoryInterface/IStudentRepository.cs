using DataBase;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepositoryInterface
{
    interface IStudentRepository : IRepository<Student, int>
    {
    }
}
