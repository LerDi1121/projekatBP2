using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceWPF.Controllers
{
    public static class TestController
    {
        public static void AddTest(Test data)
        {
            MainWindow.UnitOfWork_.TestRepository.Add(data);
            MainWindow.UnitOfWork_.TestRepository.Save();

        }
    }
}
