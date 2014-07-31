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
            //for (int i = 4; i >= 1; i-- )
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}

            // 字符串处理

            //Console.WriteLine("input IP address:");
            //string url = Console.ReadLine();
            //string protocol = GetProtocal(url);
            //Console.WriteLine(protocol);

            // 字符串处理 plus
            // hello world lee --> HelloWorldLee 

            Console.WriteLine("input a string, split by space ");
            string str = Console.ReadLine();
            string result = transString(str);
            Console.WriteLine("result is  " + result);

            Console.ReadLine();

        }

        private static string transString(string str)
        {
            string[] strArr = str.Split(" ".ToCharArray());
            string[] descArr = new string[strArr.Length];
            for(int i=0 ; i< strArr.Length; i++)
            {
                string word = transWord(strArr[i]);
                descArr[i] = word;
            }
            return string.Join("", descArr);
        }

        private static string transWord(string p)
        {
            string res = "";
            for (int j = 0; j < p.Length; j++)
            {
                if (j == 0)
                    res += p[j].ToString().ToUpper();
                else
                    res += p[j].ToString().ToLower();
            }
            return res;
        }

        //private static string GetProtocal(string url)
        //{
        //    string [] strArr = url.Split(":".ToCharArray());
        //    if(strArr.Length == 2)
        //    {
        //        return "IP Protocal is " + strArr[0];
        //    }
        //    else
        //    {
        //        return "Wrong IP Address!!!";
        //    }
        //}
    }
}
