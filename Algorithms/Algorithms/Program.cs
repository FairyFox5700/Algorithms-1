using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.UNION_FIND;
using System.Diagnostics;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalElement = 10;
            QuickUnionUF qu = new QuickUnionUF(totalElement);
            QuickFindUF qf = new QuickFindUF(totalElement);

            #region Quick Union Test
            Stopwatch swQU = new Stopwatch();
            swQU.Start();
            //perform the union operation to connect the components
            qu.Union(6, 5);
            qu.Union(2, 9);
            qu.Union(4, 3);
            qu.Union(9, 4);
            qu.Union(3, 6);

            //check if the components are connected or not
            Console.WriteLine("0 & 1 are connected - " + qu.Connected(0, 1));
            Console.WriteLine("1 & 5 are connected - " + qu.Connected(1, 5));
            Console.WriteLine("1 & 2 are connected - " + qu.Connected(1, 2));
            Console.WriteLine("3 & 6 are connected - " + qu.Connected(3, 6));
            Console.WriteLine("2 & 3 are connected - " + qu.Connected(2, 3));
            swQU.Stop();
            #endregion

            #region Quick Find Test 
            Stopwatch swQF = new Stopwatch();
            swQF.Start();
            //perform the union operation to connect the components
            qf.Union(6, 5);
            qf.Union(2, 9);
            qf.Union(4, 3);
            qf.Union(9, 4);
            qf.Union(3, 6);

            //check if the components are connected or not
            Console.WriteLine("0 & 1 are connected - " + qf.Connected(0, 1));
            Console.WriteLine("1 & 5 are connected - " + qf.Connected(1, 5));
            Console.WriteLine("1 & 2 are connected - " + qf.Connected(1, 2));
            Console.WriteLine("3 & 6 are connected - " + qf.Connected(3, 6));
            Console.WriteLine("2 & 3 are connected - " + qf.Connected(2, 3));
            swQF.Stop();
            #endregion

            Console.WriteLine("Total time taken to perform operations using Quick Union: " + swQU.Elapsed);
            Console.WriteLine("Total time taken to perform operations using Quick Find: " + swQF.Elapsed);
            Console.ReadLine();
        }
    }
}
