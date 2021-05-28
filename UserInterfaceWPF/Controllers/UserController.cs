using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterfaceWPF.Repository;
using UserInterfaceWPF.TransferModels;

namespace UserInterfaceWPF.Controllers
{
   static  class UserController
    {
       static  public User LogIn(LoginModel data)
        {
            User retVal = null;
            UnitOfWork repo = new UnitOfWork();
            var temp = repo.UserRepository.GetAll();
            //.Where(U => U.Username == data.username && U.Password == data.password);
            foreach(User u in temp)
            {
                if (u.Username==data.username && u.Password == data.password)
                { 
                    retVal = u;
                    break;
                }
            }
            return retVal;
        }
    }
}
