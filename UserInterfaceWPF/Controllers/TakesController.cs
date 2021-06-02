using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceWPF.Controllers
{
    public static class TakesController
    {
        public static Mark AddTakesAndGetMark(Takes data)
        {
            Mark Mark = MarkController.CreateMark(data);
            data.Marks = Mark;
            MainWindow.UnitOfWork_.TakesRepository.Add(data);
            MainWindow.UnitOfWork_.TakesRepository.Save();
            return Mark;
        }
    }
}
