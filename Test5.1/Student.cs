using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5._1
{
    // 定义基类 学生
    class Student
    {
        protected string name;
        protected int age;
        internal static int number;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }

        public Student()
        {
            this.name = "无名";
            this.age = 0;
        }

        public Student(string n, int a)
        {
            this.name = n;
            this.age = a;
            ++number;
        }

        //  定义返回平均成绩的虚方法，
        internal virtual double Average()
        {
            return 0;
        }  
    }

    // 定义派生类 小学生
    class Pupil : Student
    {
        private double scoreChinese;
        private double scoreMath;

        public Pupil(string n, int a, double sC, double sM)
            : base(n, a)
        {
            this.scoreChinese = sC;
            this.scoreMath = sM;
        }

        internal override double Average()
        {
            return (this.scoreMath + this.scoreChinese) / 2;
        }
    }

    // 定义派生类 中学生
    class MiddleStudent : Pupil
    {
        private double scoreEnglish;

        public MiddleStudent(string n, int a, double sC, double sM, double sE)
            : base(n, a, sC, sM)
        {
            this.scoreEnglish = sE;
        }

        internal override double Average()
        {
            return (base.Average() * 2 + this.scoreEnglish) / 3;
        }
    }

    // 定义派生类 大学生
    class UnderGradute : Student
    {
        private double compulsory;
        private double optional;

        public UnderGradute(string n, int a, double cm, double op)
            :base(n,a)
        {
            this.compulsory = cm;
            this.optional = op;
        }

        internal override double Average()
        {
            return (this.compulsory + this.optional) / 2;
        }
    }
}
