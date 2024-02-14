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
            int a,b,n;
            string[] Arr = { "1","2","3","4" };
            b = 0;
            n = 4;
            Console.WriteLine("目前隊伍:");
            foreach (string num in Arr)
            {
                Console.Write("{0}", num);
                Console.Write(" ");
            }
            Console.WriteLine();
            while (b==0)
            {
                Console.WriteLine("請輸入指令 ( 輸入 1 抽取號碼牌、輸入 2 將第一個人移出隊伍、輸入 0 結束程式 ):");
                a = int.Parse(Console.ReadLine());
                if(a==1)
                {
                    Press1(ref n, ref Arr);
                }
                else if(a==2)
                {
                    Press2(ref Arr);
                }
                else
                {
                    Console.Write("結束程式");
                    break;
                }
            }
            Console.ReadKey();
        }
        private static void Press1(ref int n ,ref string[] Arr)
        {

            n = n + 1;
            Array.Resize(ref Arr, Arr.Length + 1);

            Arr[Arr.Length-1] = n.ToString();
            Console.WriteLine("{0}號領取號碼牌", n );
            
            Console.WriteLine("目前隊伍:");
            foreach(string num in Arr)
            {
                Console.Write("{0}",num);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        private static void Press2( ref string[] Arr)
        {

            if (Arr.Length==0)
            {
                Console.Write("目前沒人在隊伍裡");
                Console.WriteLine();
                Console.WriteLine("目前隊伍:");
                foreach (string num in Arr)
                {
                    Console.Write("{0}", num);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            else
            {
               


                Console.Write("{0}號離開隊伍",Arr[0]);
                for (int i = 0; i < Arr.Length-1; i++)
                {
                    Arr[i] = Arr[i + 1];
                }
                Array.Resize(ref Arr, Arr.Length - 1);
                Console.WriteLine();
                Console.WriteLine("目前隊伍:");
                foreach (string num in Arr)
                {
                    Console.Write("{0}", num);
                    Console.Write(" ");
                }
                Console.WriteLine();


            }

        }
        
    }
}
