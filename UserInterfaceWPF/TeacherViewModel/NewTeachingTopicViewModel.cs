using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceWPF.TeacherViewModel
{
   public  class NewTeachingTopicViewModel:BindableBase
    {
        public List<string> AllTopic { get; set; } = new List<string>();
        public string SelectedItem { get; set; }
        public MyICommand AddCommand { get; set; }
        public NewTeachingTopicViewModel()
        {
            AddCommand = new MyICommand(OnSend, CanSend);
            
        }
        public void GetTopic()
        {

        }

        private bool CanSend()
        {
            throw new NotImplementedException();
        }

        private void OnSend()
        {
            throw new NotImplementedException();
        }
    }
}
