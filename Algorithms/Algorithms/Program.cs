using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.UNION_FIND;
using System.Diagnostics;
using Algorithms.GENERIC_STACK;
using Algorithms.PRIORITY_QUEUES;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Commented Code for the UNION-FIND
            //int totalElement = 10;
            //#region Quick Union Test
            //Stopwatch swQU = new Stopwatch();
            //swQU.Start();

            ////initialize the object
            //QuickUnionUF qu = new QuickUnionUF(totalElement);
            ////perform the union operation to connect the components
            //qu.Union(6, 5);
            //qu.Union(2, 9);
            //qu.Union(4, 3);
            //qu.Union(9, 4);
            //qu.Union(3, 6);

            ////check if the components are connected or not
            //Console.WriteLine("0 & 1 are connected - " + qu.Connected(0, 1));
            //Console.WriteLine("1 & 5 are connected - " + qu.Connected(1, 5));
            //Console.WriteLine("1 & 2 are connected - " + qu.Connected(1, 2));
            //Console.WriteLine("3 & 6 are connected - " + qu.Connected(3, 6));
            //Console.WriteLine("2 & 3 are connected - " + qu.Connected(2, 3));
            //swQU.Stop();
            //#endregion

            //#region Quick Find Test 
            //Stopwatch swQF = new Stopwatch();
            //swQF.Start();

            ////initialize the object
            //QuickFindUF qf = new QuickFindUF(totalElement);
            ////perform the union operation to connect the components
            //qf.Union(6, 5);
            //qf.Union(2, 9);
            //qf.Union(4, 3);
            //qf.Union(9, 4);
            //qf.Union(3, 6);

            ////check if the components are connected or not
            //Console.WriteLine("0 & 1 are connected - " + qf.Connected(0, 1));
            //Console.WriteLine("1 & 5 are connected - " + qf.Connected(1, 5));
            //Console.WriteLine("1 & 2 are connected - " + qf.Connected(1, 2));
            //Console.WriteLine("3 & 6 are connected - " + qf.Connected(3, 6));
            //Console.WriteLine("2 & 3 are connected - " + qf.Connected(2, 3));
            //swQF.Stop();
            //#endregion

            //#region Weighted Quick Find Path Compression Test 
            //Stopwatch swWQFPC = new Stopwatch();
            //swWQFPC.Start();

            ////initialize the object
            //WeightedQUPathCompression wqupc = new WeightedQUPathCompression(totalElement);
            ////perform the union operation to connect the components
            //wqupc.Union(6, 5);
            //wqupc.Union(2, 9);
            //wqupc.Union(4, 3);
            //wqupc.Union(9, 4);
            //wqupc.Union(3, 6);

            ////check if the components are connected or not
            //Console.WriteLine("0 & 1 are connected - " + wqupc.Connected(0, 1));
            //Console.WriteLine("1 & 5 are connected - " + wqupc.Connected(1, 5));
            //Console.WriteLine("1 & 2 are connected - " + wqupc.Connected(1, 2));
            //Console.WriteLine("3 & 6 are connected - " + wqupc.Connected(3, 6));
            //Console.WriteLine("2 & 3 are connected - " + wqupc.Connected(2, 3));
            //swWQFPC.Stop();
            //#endregion

            //Console.WriteLine("Total time taken to perform operations using Quick Find: " + swQF.Elapsed);
            //Console.WriteLine("Total time taken to perform operations using Quick Union: " + swQU.Elapsed);
            //Console.WriteLine("Total time taken to perform operations using Weighted Quick Find Path Compression: " + swWQFPC.Elapsed); 
            #endregion

            #region Commented Code for the Generic Stack using Linked List
            //GenericLinkedListStack<String> llStack = new GenericLinkedListStack<String>();

            //llStack.Push("A");
            //llStack.Push("B");
            //llStack.Push("C");
            //llStack.Push("D");

            //Console.WriteLine("Printing Stack:");
            //foreach (string item in llStack)
            //{
            //    Console.Write(item + ", ");
            //}

            //llStack.Pop();
            //llStack.Pop();
            //llStack.Pop();

            //Console.WriteLine("\nPrinting Stack:");
            //foreach (string item in llStack)
            //{
            //    Console.Write(item + ", ");
            //}

            //llStack.Push("C");
            //llStack.Push("D");
            //llStack.Push("B");
            //llStack.Push("X");
            //llStack.Push("Y");

            //Console.WriteLine("\nPrinting Stack:");
            //foreach (string item in llStack)
            //{
            //    Console.Write(item + ", ");
            //}
            #endregion

            #region Commented Code for the Generic Stack using Fixed Length Array
            //GenericFixedArrayStack<String> faStack = new GenericFixedArrayStack<String>(10);

            //faStack.Push("A");
            //faStack.Push("B");
            //faStack.Push("C");
            //faStack.Push("D");

            //faStack.Pop();
            //faStack.Pop();
            //faStack.Pop();

            //faStack.Push("D");
            //faStack.Push("C");
            //faStack.Push("B"); 
            #endregion

            #region Commented Code for the Generic Stack using Resizing Array
            //GenericResizingArrayStack<String> rsStack = new GenericResizingArrayStack<String>();

            //rsStack.Push("A");
            //rsStack.Push("B");
            //rsStack.Push("C");
            //rsStack.Push("D");

            //Console.WriteLine("Printing Stack:");
            //foreach (string item in rsStack)
            //{
            //    Console.Write(item + ", ");
            //}

            //rsStack.Pop();
            //rsStack.Pop();
            //rsStack.Pop();

            //Console.WriteLine("\nPrinting Stack:");
            //foreach (string item in rsStack)
            //{
            //    Console.Write(item + ", ");
            //}

            //rsStack.Push("D");
            //rsStack.Push("C");
            //rsStack.Push("B");
            //rsStack.Push("B");
            //rsStack.Push("B");
            //rsStack.Push("B");

            //Console.WriteLine("\nPrinting Stack:");
            //foreach (string item in rsStack)
            //{
            //    Console.Write(item + ", ");
            //}
            #endregion

            #region Commented Code for the Unordered Priority Queue
            //UnorderedPriorityQueue _upq = new UnorderedPriorityQueue(10);

            //_upq.insert(123);
            //_upq.insert(127);
            //_upq.insert(125);
            //_upq.delMax(); 
            #endregion

            Console.ReadKey();
        }
    }
}
