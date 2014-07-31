using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 输出4行星号
namespace ConApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 输出阶梯形星号
            // *
            // ***
            // *****
            // *******
            
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= 2 * i - 1; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.Write("\n");

            //}

            // 输出反过来的阶梯形
            // ****
            // ***
            // **
            // *

            for (int i = 4; i >= 1; i-- )
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

                Console.ReadLine();

        }
    }
}
