using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 5;
            int s2 = 2;
            int r = s1 / s2;
            Console.WriteLine(r);

            double s11 = 5;//int olabilir.
            double s22 = 2;//int olabilir.
            double rr = s11 / s22;
            Console.WriteLine(rr);

            Console.WriteLine(Convert.ToInt32(2.6));

            Console.ReadLine();

        }
    }
}
