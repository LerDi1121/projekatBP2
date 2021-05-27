using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.ModelRepository;

namespace UserInterfaceWPF.Repository
{
    interface IUnitOfWork: IDisposable
    {
        AnswersRepository AnswersRepository { get; }
        CourseRepository CourseRepository { get; }
        MarkRepository MarkRepository { get; }
        MessageRepository MessageRepository { get; }
        QuestionRepository QuestionRepository { get; }
        ReceiveRepository ReceiveRepository { get; }
        RegisteredRepository RegisteredRepository { get; }
        StudentRepository StudentRepository { get; }
        TakesRepository TakesRepository { get; }
        TeacherRepository TeacherRepository { get; }
        Teaching_topicRepository Teaching_topicRepository { get; }
        TestRepository TestRepository { get; }
        UserRepository UserRepository { get; }
       
    }
}
