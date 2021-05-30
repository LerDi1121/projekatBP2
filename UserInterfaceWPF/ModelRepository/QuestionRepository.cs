using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class QuestionRepository:Repository<Question,int>,IQuestionRepository
    {
        public QuestionRepository(DistanceLearningContainer context):base (context)
        {
                
        }
    }
}
