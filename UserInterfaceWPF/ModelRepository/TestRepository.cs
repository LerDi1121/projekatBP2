﻿using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    public class TestRepository:Repository<Test,int>,ITestRepository
    {
        public TestRepository(DistanceLearningContainer context):base(context)
        {

        }
    }
}
