using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static int[] RandomN(int num)
        {
            int[] arr;
            arr = new int[num];
            int ranNo;
            Random ranObj = new Random();
            for (int i = 0; i < num; i++)
            {
                ranNo = ranObj.Next(101);
                arr[i] = ranNo;
            }
            Array.Sort(arr);
            return (arr);
        }

        static void Main(string[] args)
        {
            int a, b, N;
            string str1 = "";
            Console.Write("Input N :");
            N = int.Parse(Console.ReadLine());
            int[] data = RandomN(N);
            foreach (int num in data)
                str1 += num.ToString() + " ";
            Console.WriteLine("{0}",str1);

            Console.Write("Input Start :");
            a = int.Parse(Console.ReadLine());

            Console.Write("Input End :");
            b = int.Parse(Console.ReadLine());
            int n = 0;
            foreach(int num in data)
            {
                if (num>a && num<b)
                {
                    n += 1;
                }
            }
            Console.Write("{0} numbers.",n);



            Console.ReadKey();


        }
    }
}
