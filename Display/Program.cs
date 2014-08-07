using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    //class Program
    //{

    //    //输出杨辉三角的前10行
    //    static void Main(string[] args)
    //    {
    //        // 使用二维数组存储杨辉三角的值
    //        int[,] arr = new int[10,10];  

    //        for (int i = 0; i < 10; ++i)
    //        {
    //            for (int j = 0; j <= i; ++j)
    //            {
    //                if (j == 0 || j == i)
    //                {
    //                    arr[i, j] = 1;
    //                    Console.Write(arr[i, j]+"\t");
    //                    continue;
    //                }
    //                arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
    //                Console.Write(arr[i, j] + "\t");
    //            }
    //            Console.Write("\n");
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //下面用数组型数组存储杨辉三角的数值，并完成生成和显示


    class Program
    {
        //输出杨辉三角的前10行
        static void Main(string[] args)
        {
            Console.WriteLine("请输入杨辉三角的行数：");
            int row = int.Parse(Console.ReadLine().Trim());
            Yanghui yh = new Yanghui();
            yh.Show(row);

            Console.ReadLine();

        }
    }

}
