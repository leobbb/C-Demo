using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6._1
{
    class Student
    {
        string name;
        int stuNo;

        public Student(string na, int no) 
        {
            this.name = na;
            this.stuNo = no;
        }

        public string ShowMsg()
        {
            return string.Format("学号：{0}，姓名：{1}！", stuNo, name);
        }
    }
}
