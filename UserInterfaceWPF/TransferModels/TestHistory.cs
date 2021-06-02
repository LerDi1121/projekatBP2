using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceWPF.TransferModels
{
    public class TestHistory:TestForStudentView
    {
        private string markDescription;
        private int  markValue;
        public int MarkValue
        {
            get => markValue;
            set
            {
                if (this.markValue != value)
                {
                    this.markValue = value;
                    RaisePropertyChanged("MarkValue");
                }
            }
        }
        public string MarkDescription
        {
            get => markDescription;
            set
            {
                if (this.markDescription != value)
                {
                    this.markDescription = value;
                    RaisePropertyChanged("MarkDescription");
                }
            }
        }


    }
}
