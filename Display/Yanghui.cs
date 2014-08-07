using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Display
{
    // 生成杨辉三角的类
    class Yanghui
    {

        public void Show(int row)
        {
            //创建数组型数组
            int[][] arr = new int[row][];
            for (int i = 0; i < row ; ++i)
            {
                // 创建子数组
                arr[i] = new int[i + 1];

                for (int j = 0; j <= i; ++j)
                {
                    if (j == 0 || j == i)
                    {
                        arr[i][j] = 1;
                        Console.Write(arr[i][j] + "\t");
                        continue;
                    }
                    arr[i][j] = arr[i - 1][j - 1] + arr[i - 1][j];
                    Console.Write(arr[i][j] + "\t");
                }
                Console.Write("\n");
            }
        }
    }

}
