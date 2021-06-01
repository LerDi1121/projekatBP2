using DataBase;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepositoryInterface
{
    interface IQuestionRepository : IRepository<Question, int>
    {
    }
}
