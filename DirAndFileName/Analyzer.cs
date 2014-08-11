using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirAndFileName
{
    class Analyzer
    {
        private int num;

        internal int Num
        {
            get { return num; }
            set { num = value; }
        }


        internal void SplitPath(string path, out string dir, out string file)
        {
            int i;
            i = path.LastIndexOf("\\");
            dir = path.Substring(0, i + 1);
            file = path.Substring(i + 1);
        }
    }
}
