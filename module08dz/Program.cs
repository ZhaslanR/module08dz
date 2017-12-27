using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module08dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();

            test.Add(10);
            test.Add(15);
            test.InSet(5, 1);

            for(int i = 0;i<test.SizeMas;i++)
            {
                Console.WriteLine(test[i]);
            }

            Console.ReadLine();
        }
    }
}
