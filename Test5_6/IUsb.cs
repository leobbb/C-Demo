using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5_6
{
    // 定义Usb 接口
    interface IUsb          
    {
        int MaxSpeed
        {
            get;
        }
        string TransData(string from, string to);
    }

    // 定义蓝牙接口
    interface IBluetooth
    {
        int MaxSpeed
        {
            get;
        }

        string TransData(string from, string to);
    }
}
