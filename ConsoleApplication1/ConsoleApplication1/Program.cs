using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
                arr[i] = Console.ReadLine();

            for (int i = 0; i < n; i++)
                Console.WriteLine(likeTheName(arr[i]));
        }

        private static string likeTheName(string name)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char item in name.ToArray())
            {
                if(dict.ContainsKey(item))
                {
                    int value = 0;

                    if(dict.TryGetValue(item, out value))
                    {
                        value += 1;

                        dict.Remove(item);
                        dict.Add(item, value);
                    }
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            int distictElement = 0;
            int a = 0;
            int b = 0;
            int c = 0;

            foreach (KeyValuePair<char, int> item in dict)
            {
                distictElement++;

                if (distictElement == 1)
                    a = item.Value;
                else if (distictElement == 2)
                    b = item.Value;
                else if (distictElement == 3)
                    c = item.Value;
            }

            if(distictElement == 3 && (a == b) && (b == c))
            {
                return "OK";
            }
            else
            {
                return "Not OK";
            }
        }
    }
}
