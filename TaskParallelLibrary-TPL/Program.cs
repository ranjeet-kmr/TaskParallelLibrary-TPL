using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary_TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            
          var t1 =  Task.Factory.StartNew(() => impStuff(1,1000));
          var t2 =  Task.Factory.StartNew(() => impStuff(2, 2500));
          var t3 =  Task.Factory.StartNew(() => impStuff(3, 2000));

            var tasklist = new List<Task> { t1, t2, t3 };
           // Task.WaitAll(tasklist.ToArray());
          var t4 =  Task.Factory.StartNew(() => otherimpStuff(1, 1000));
          var t5 =   Task.Factory.StartNew(() => otherimpStuff(2, 2500));
          var t6 =   Task.Factory.StartNew(() => otherimpStuff(3, 2000));

            Console.WriteLine("Press any key to quit");
            Console.Read();
        }

        static void  impStuff(int id , int sleepTime)
        {
            Console.WriteLine("Task {0} is Begining impStuff execution", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Task {0} has completed impStuff execution", id);
        }

        static void otherimpStuff(int id, int sleepTime)
        {
            Console.WriteLine("Task {0} is Begining otherimpStuff execution", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Task {0} has completed otherimpStuff execution", id);
        }
    }
}
