using DataBase;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepositoryInterface
{
    interface ITestRepository : IRepository<Test, int>
    {
    }
}
