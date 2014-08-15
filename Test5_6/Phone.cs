using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5_6
{

    // 定义抽象基类
    public abstract class Phone
    {
        public abstract string Call(string name);
    }

    // 定义类MP3 实现 IUsb 接口
    public class Mp3 : IUsb
    {
        public int MaxSpeed
        {
            get
            {
                return 480;
            }
        }

        public string TransData(string from, string to)
        {
            return string.Format("数据传输：从{0} 到 {1} ", from, to);
        }
    }

    // 定义派生类Mobile 并实现IUsb 和 IBluetooth 接口
    public class Mobile : Phone, IUsb, IBluetooth
    {
        int IUsb.MaxSpeed
        {
            get
            {
                return 480;
            }
        }

        string IUsb.TransData(string from, string to)
        {
            return string.Format("USB数据传输： 从{0} 到{1} ", from, to);
        }

        int IBluetooth.MaxSpeed
        {
            get
            {
                return 64;
            }
        }

        string IBluetooth.TransData(string from, string to)
        {
            return string.Format("Bluetooth 数据传输: 从 {0} 到{1} ", from, to);
        }

        public override string Call(string name)
        {
            return string.Format("和{0}通话中……", name);
        }
    }
}
