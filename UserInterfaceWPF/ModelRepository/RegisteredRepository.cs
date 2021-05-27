﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.ModelRepositoryInterface;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepository
{
    class RegisteredRepository: Repository<Registered, int>, IRegisteredRepository
    {
        public RegisteredRepository(DistanceLearningContainer context):base(context)
        {

        }
    }
}