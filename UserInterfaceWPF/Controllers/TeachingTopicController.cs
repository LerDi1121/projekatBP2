using DataBase;
using System.Collections.Generic;

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

        internal static void DeleteTopic(Teaching_topic data)
        {
            MainWindow.UnitOfWork_.Teaching_topicRepository.Remove(data);
            MainWindow.UnitOfWork_.Teaching_topicRepository.Save();
        }
    }
}
