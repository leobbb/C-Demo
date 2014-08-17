using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6._3
{
    // 定义基类 学生
    internal abstract class Student
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Student()
        {
        }

        public Student(string n)
        {
            this.name = n;
        }

        internal abstract string ShowMsg();

    }

    // 定义派生类 小学生
    class Pupil : Student
    {

        public Pupil(string n)
            : base(n)
        {
        }

        internal override string ShowMsg()
        {
            return string.Format("我是小学生--{0}，我爱画画。", base.Name);
        }
    }

    // 定义派生类 中学生
    class MiddleStudent : Student
    {

        public MiddleStudent(string n)
            : base(n)
        {
        }

        internal override string ShowMsg()
        {
            return string.Format("我是中学生--{0},我谈恋爱。", base.Name);
        }
    }

    // 定义派生类 大学生
    class UnderGradute : Student
    {

        public UnderGradute(string n)
            :base(n)
        {
        }

        internal override string ShowMsg()
        {
            return string.Format("我是大学生--{0}，我要喝酒。", base.Name);
        }
    }
}
