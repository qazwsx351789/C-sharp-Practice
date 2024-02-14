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
            int Money ,a ,b;
            Console.Write("存錢筒內初始金額:");
            Money = int.Parse(Console.ReadLine());
            b = 0;
            while(b==0)
            {
                Console.WriteLine("請輸入指令 :( 輸入 1 領錢、輸入 2 存錢、輸入 0 結束程式 )");
                a = int.Parse(Console.ReadLine());
                addMoney(a, ref Money);
                if(a==0)
                {
                    break;
                }

            }

            Console.ReadKey();
        }
        private static void addMoney(int a,ref int money)
        {
            int add ,min;
            if(a==2)
            {
                Console.WriteLine("請輸入金額:");
                 add = int.Parse(Console.ReadLine());
                money = money + add;
                Console.WriteLine("存入{0}元",add);
                Console.WriteLine("目前餘額:{0}元",money);
            }
            else if(a==1)
            {
                Console.WriteLine("請輸入金額:");
                min = int.Parse(Console.ReadLine());
                if(money-min>=0)
                {
                    money = money - min;
                    Console.WriteLine("領出{0}元",min);
                    Console.WriteLine("目前餘額:{0}元",money);
                }
                else
                {
                    Console.WriteLine("餘額不足");
                    Console.WriteLine("目前餘額:{0}元",money);
                }

            }
            else
            {
                Console.WriteLine("結束程式");
            }
        }
    }
}
