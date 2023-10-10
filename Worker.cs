using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_task2
{
    public class Worker
    {
        public string Name {  get; set; }
        public string Surname {  get; set; }
        private byte _experience;
        private string _workerCode;



        public byte Experience 
        {
            get
            {
                return _experience;
            }
            set
            {
                if(value>0)
                {
                    _experience = value;
                }
            }
        }
        public string WorkerCode
        {
            get
            {
                return _workerCode;
            }
            set
            {
                if (value[0]>='A' && value[0] < 'Z')
                {
                    for(int i = 0; i < value.Length-1; i++)
                    {
                        if ((value[i] == ' ' && value[i + 1] >= 'A' && value[i + 1] <= 'Z'))
                        {
                            _workerCode = value;
                        }
                    }
                }
            }
        }
    }
}
