using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelLibrary_TPL
{
    class linqtest
    {
        static void Main()
        {
            int[] ds = { 12, 21, 54, 65, 777, 77, 7, 3, 2, 1, 0, 453 };

            var sa = from k in ds
                     where k > 40
                     orderby k descending
                     select k;
            foreach (var x in sa)
      
                Console.Write(x   + " ");
                Console.ReadLine();


        }


    }
}
