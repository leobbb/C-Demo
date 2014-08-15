using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5._3
{
    class Player
    {
    }

     class MP3 : IPlayer
    {
        public string Play()
        {
            return "MP3: 正在播放....";
        }

        public string Stop()
        {
            return "MP3: 已经停止。";
        }

        public string Pause()
        {
            return "MP3: 暂停播放。";
        }

        public string Pre()
        {
            return "MP3: 播放上一首。";
        }

        public string Next()
        {
            return "MP3: 播放下一首。";
        }

    }

    public class Avi : IPlayer
    {
        public string Play()
        {
            return "AVI: 正在播放....";
        }

        public string Stop()
        {
            return "AVI: 已经停止。";
        }

        public string Pause()
        {
            return "AVI: 暂停播放。";
        }

        public string Pre()
        {
            return "AVI: 播放上一首。";
        }

        public string Next()
        {
            return "AVI: 播放下一首。";
        }

    }
}
