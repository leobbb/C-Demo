using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test8_3
{

    class Student
    {
        public string name;
        public char sex;
        public Student(string na, char se)
        {
            name = na;
            sex = se;
        }
    }

    class StudentEventArgs : EventArgs
    {
        private Student someone;

        public StudentEventArgs(Student s)
        {
            someone = s;
        }

        public Student student
        {
            get { return someone; }
        }
    }

    class Grade
    {
        private ArrayList list;

        public event EventHandler<StudentEventArgs> onNewStudent;

        public Grade()
        {
            list = new ArrayList();
        }

        public void Add(Student s)
        {
            list.Add(s);
        }

        public void ProcessRegister()
        {
            foreach (Student s in list)
            {
                StudentEventArgs e = new StudentEventArgs(s);
                if (onNewStudent != null && s != null)
                    onNewStudent(this, e);
            }
        }
    }

    class School
    {
        private int students;
        private ArrayList list;

        public School()
        {
            students = 0;
            list = new ArrayList();
        }

        public Student this[int index]
        {
            get
            {
                if (index < 0 || index >= list.Count)
                    return (Student)list[0];
                else
                    return (Student)list[index];
            }

        }

        //public override int Count
        //{
        //    get { return students; }
        //}

        private void Add_NewStudent(object sender, StudentEventArgs e)
        {
            if(e.student != null)
            {
                students++;
                list.Add(e.student);
            }
        }

        public void subscribeEvent(Grade g)
        {
            g.onNewStudent += new EventHandler<StudentEventArgs>(Add_NewStudent);
        }

        public int count
        {
            get { return students; }
        }
    }
}
