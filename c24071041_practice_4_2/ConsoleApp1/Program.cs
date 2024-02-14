using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade, all, x, n, mean;
            x = 0;
            
            int[] num = { 55, 100, 34, 67, 89, 96, 46, 71, 82, 91 };
            Console.WriteLine("排序前的成績:");
            foreach (int word in num)
                Console.Write(" {0} ", word);
            Console.WriteLine();
            Console.WriteLine("排序後的成績:");
            Array.Sort(num);
            foreach (int word in num)
                Console.Write(" {0} ", word);
            Console.WriteLine();
            while(x==0)
            {
                Console.Write("請輸入一個分數(0~99):");
                grade = int.Parse(Console.ReadLine());
                all = 0;
                n = 0;
                if (grade == -1)
                    break;


                foreach (int word in num)
                {
                    if (grade < word)
                    {
                        all += word;
                        n += 1;
                    }
                    else
                        continue;
                }
                mean = all / n;
                Console.WriteLine("比{0}大的分數平均{1}",grade,mean);
                Console.WriteLine();
            }
                Console.Read();
        }
    }
}
