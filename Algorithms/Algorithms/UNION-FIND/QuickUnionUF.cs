using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.UNION_FIND
{
    class QuickUnionUF
    {
        private int[] id;

        //constructor to initialize the array for the UNION FIND
        public QuickUnionUF(int n)
        {
            id = new int[n];

            for (int i = 0; i < n; i++)
            {
                id[i] = i;
            }
        }

        //method to find the root of the element
        private int root(int i)
        {
            while (i != id[i]) i = id[i];
            return i;
        }

        //method to check if the two componenets are connected
        public bool Connected(int p, int q)
        {
            return root(p) == root(q);
        }

        //method to connect the two componenets
        public void Union(int p, int q)
        {
            int i = root(p);
            int j = root(q);
            id[i] = j;
        }

        public static void Main()
        {
            //initialize the components
            QuickUnionUF uf = new QuickUnionUF(10);

            //perform the union operation to connect the components
            uf.Union(1, 4);
            uf.Union(4, 5);
            uf.Union(2, 3);
            uf.Union(2, 6);
            uf.Union(3, 6);
            uf.Union(3, 7);

            //check the elements with their component group in the array
            for (int i = 0; i < uf.id.Length; i++)
            {
                Console.WriteLine(i + " - " + uf.id[i]);
            }

            //check if the components are connected or not
            Console.WriteLine("0 & 1 are connected - " + uf.Connected(0, 1));
            Console.WriteLine("1 & 5 are connected - " + uf.Connected(1, 5));
            Console.WriteLine("1 & 2 are connected - " + uf.Connected(1, 2));
            Console.WriteLine("3 & 6 are connected - " + uf.Connected(3, 6));
            Console.WriteLine("2 & 3 are connected - " + uf.Connected(2, 3));
            Console.ReadLine();
        }
    }
}
