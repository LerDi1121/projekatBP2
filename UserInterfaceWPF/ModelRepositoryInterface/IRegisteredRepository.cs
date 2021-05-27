using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.Repository;

namespace UserInterfaceWPF.ModelRepositoryInterface
{
    interface IRegisteredRepository:IRepository<Registered,int>
    {
    }
}
