using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_task2
{
    public class Department
    {
        public string Name { get; set; }
        public Worker[]Workers=Array.Empty<Worker>();

        public void AddWorker(Worker worker)
        {
            Array.Resize(ref Workers,Workers.Length+1);
            Workers[Workers.Length-1] = worker;
        }
        public Worker[]SearchWorker(string name)
        {
            Worker[]wantedworker=Array.Empty<Worker>();
            for(int  i=0;i<Workers.Length;i++)
            {
                if (Workers[i].Name==name)
                { 
                    Array.Resize(ref wantedworker,Workers.Length+1);
                    wantedworker[^1] = Workers[i];
                }
            }
            return wantedworker;
        }
        public void ShowAllWorkers()
        {
            foreach(Worker worker in Workers)
            {
                Console.WriteLine(worker.Name);
            }
        }
    }
}
