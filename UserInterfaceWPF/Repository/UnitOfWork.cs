using System;
using UserInterfaceWPF.ModelRepository;

namespace UserInterfaceWPF.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly DistanceLearningContainer context;
        public UnitOfWork()
        {
            this.context = new DistanceLearningContainer();

            AnswersRepository = new AnswersRepository(this.context);
            CourseRepository = new CourseRepository(this.context);
            MarkRepository = new MarkRepository(this.context);
            MessageRepository = new MessageRepository(this.context);
            QuestionRepository = new QuestionRepository(context);
            ReceiveRepository = new ReceiveRepository(this.context);
            RegisteredRepository = new RegisteredRepository(this.context);
            StudentRepository = new StudentRepository(this.context);
            TakesRepository = new TakesRepository(this.context);
            TeacherRepository = new TeacherRepository(this.context);
            Teaching_topicRepository = new Teaching_topicRepository(this.context);
            TestRepository = new TestRepository(this.context);
            UserRepository = new UserRepository(this.context);

        }
        #region field 
        public AnswersRepository AnswersRepository { get; set; }

        public CourseRepository CourseRepository { get; set; }

        public MarkRepository MarkRepository { get; set; }

        public MessageRepository MessageRepository { get; set; }

        public QuestionRepository QuestionRepository { get; set; }

        public ReceiveRepository ReceiveRepository { get; set; }

        public RegisteredRepository RegisteredRepository { get; set; }

        public StudentRepository StudentRepository { get; set; }

        public TakesRepository TakesRepository { get; set; }

        public TeacherRepository TeacherRepository { get; set; }
        public Teaching_topicRepository Teaching_topicRepository { get; set; }

        public TestRepository TestRepository { get; set; }

        public UserRepository UserRepository { get; set; }
        ~UnitOfWork()
        {
            context.Dispose();
        }
        #endregion
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
