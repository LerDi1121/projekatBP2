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
           
            var temp = MainWindow.UnitOfWork_.UserRepository.GetAll();
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
        static public User getUserByUsername( string username)
        {
            User retVal = null;
          
            var temp = MainWindow.UnitOfWork_.UserRepository.GetAll().Where(u => u.Username == username)?.First();
            retVal = temp;
            return retVal;

        }
        static public HashSet<string> getAllUsername()
        {
            HashSet<string> retVal = new HashSet<string>() ;
          
            var temp = MainWindow.UnitOfWork_.UserRepository.GetAll();
            foreach( User  u in temp)
            {
                retVal.Add(u.Username);
            }
           
            return retVal;

        }
    }
}
