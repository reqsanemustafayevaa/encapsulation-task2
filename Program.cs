using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Name = "kimse";
            worker.Experience = 10;

            Worker worker1=new Worker();
            worker1.Name = "Bartu";
            worker1.Experience = 5;

            Worker worker2=new Worker();
            worker2.Name = "Drew";
            worker2.Experience = 6;

            Department department = new Department();
            department.Name = "MK";
            department.AddWorker(worker);
            department.AddWorker(worker1);
            department.AddWorker(worker2);

            department.ShowAllWorkers();
            Worker wantedworker = department.SearchWorker("nese");
            if (wantedworker != null)
            {
                Console.WriteLine(wantedworker.Name);
            }
            else
            {
                Console.WriteLine("bele bir isci yoxdur");
            }
            Worker[] workers = department.SearchWorker("ashdvdg");
            foreach(Worker wantedWorker in workers)
            {
                Console.WriteLine(wantedworker.Name);
            }
        }
    }
}
