﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    class AnswersRepository:Repository<Answers,int>,IAnswersRepository
    {
        public AnswersRepository(DistanceLearningContainer context):base(context)
        {

        }
    }
}