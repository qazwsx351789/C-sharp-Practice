using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class practice1
    {
        static void Main(string[] args)
        {
            int num;

            for (; ; )
            {
                Console.Write("請輸入金字塔大小(請輸入正奇數):");
                num = int.Parse(Console.ReadLine());
                if(num<0 ||num%2==0)
                {
                    Console.WriteLine("請輸入正奇數");
                }
                else
                {
                    for(int i=1 ; i<=(num+1)/2 ; i++)
                    {
                        for(int k=1 ; k<=num ; k++)
                        {
                            if (k >= (num + 1 - (i-1)*2) / 2 && k <= (num + 1 + (i - 1) * 2) / 2) 
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                            
                        }
                        Console.WriteLine();
                    }


                    break;
                }
            }

            Console.ReadKey();



        }
    }
}
