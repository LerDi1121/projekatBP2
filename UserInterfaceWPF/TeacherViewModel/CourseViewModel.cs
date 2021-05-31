using DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceWPF.TeacherViewModel
{
    public class CourseViewModel: BindableBase
    {
        public static ObservableCollection<Course> Message { get; set; } = new ObservableCollection<Course>();

    }
}
