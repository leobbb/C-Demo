using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6._2
{
    class ClassList
    {
        public List<Student> stuList;

        public ClassList()
        {
            stuList = new List<Student>();
        }

        public string GetAll()
        {
            string str = string.Empty;
            foreach (var stu in stuList)
            {
                str += stu.ShowMsg() + "\n";
            }
            return str;
        }

        public Student this[int index]
        {
            get{
                if (index < 0 || index >= stuList.Count)
                {

                    throw new Exception("边界越界");
                }
                else
                {
                    return stuList[index];
                }
            }
            set
            {
                if (index < 0 || index >= stuList.Count)
                {
                    throw new Exception("边界越界");
                    return;
                }
                else
                {
                    stuList[index] = value;
                }
            }
        }


        internal void Add(string sno, string sna)
        {
            Student stu = new Student(sno, sna);
            stuList.Add(stu);
        }

        internal int Count()
        {
            return stuList.Count();
        }

        internal void DeleteAt(int p)
        {
            stuList.RemoveAt(p);
        }
    }

    class Student
    {
        private string sno;
        private string name;

        public string Sno
        {
            get { return sno; }
        }
        public string Name
        {
            get { return name; }
        }

        public Student()
        {
            this.sno = string.Empty;
            this.name = string.Empty;
        }
        public Student(string no, string na)
        {
            this.sno = no;
            this.name = na;
        }

        public string ShowMsg()
        {
            return string.Format("学号： {0}，姓名： {1} ", Sno, Name);
        }

    }
}
