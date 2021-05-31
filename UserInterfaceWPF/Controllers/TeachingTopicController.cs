using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceWPF.Controllers
{
    static class TeachingTopicController
    {
        public static ICollection<Teaching_topic> GetAllTopicForTeacher(User data)
        {
            return null;
        }
        public static void AddTeachingTopic(Teaching_topic data)
        {
            MainWindow.UnitOfWork_.Teaching_topicRepository.Add(data);
            MainWindow.UnitOfWork_.Teaching_topicRepository.Save();
        }
    }
}
