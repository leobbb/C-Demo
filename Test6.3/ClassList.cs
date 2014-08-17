using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6._3
{
    class ClassList<T> where T : Student
    {
        private List<T>  stuList;

        public ClassList()
        {
            stuList = new List<T>();
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

        public void Add(T stu)
        {
            stuList.Add(stu);
        }

        public T this[int index]
        {
            get
            {
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
                }
                else
                {
                    stuList[index] = value;
                }
            }
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

}
