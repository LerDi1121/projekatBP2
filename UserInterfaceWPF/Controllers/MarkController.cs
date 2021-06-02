using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceWPF.Controllers
{
    public static class MarkController
    {
        public static Mark CreateMark(Takes data)
        {
            int maxPoint = data.Test.Points;
            int studentPoints = data.Won_points;
            return CreateMarkFromPoints(studentPoints, maxPoint);

        }
        static Mark CreateMarkFromPoints(int wonPoints, int totalPoints)
        {
            Mark RetVale;
            double percentage = (double)wonPoints    / (double)totalPoints * 100;
            if(percentage<50)
            {
                RetVale = new Mark()
                {
                    Description_of_mark = "Nedovoljan",
                    Value_of_Mark = 1

                };
            }
            else if (percentage < 65)
            {
                RetVale = new Mark()
                {
                    Description_of_mark = "Dovoljan",
                    Value_of_Mark = 2

                };
            }
            else if (percentage < 80)
            {
                RetVale = new Mark()
                {
                    Description_of_mark = "Dobar",
                    Value_of_Mark = 3

                };

            }
            else if (percentage < 90)
            {
                RetVale = new Mark()
                {
                    Description_of_mark = "Vrlo Dobar",
                    Value_of_Mark = 4

                };
            }
            else 
            {
                RetVale = new Mark()
                {
                    Description_of_mark = "Odlican",
                    Value_of_Mark = 5

                };
            }
            return RetVale;
        }
        
     }
}
