using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City.MySchool.Class;

namespace job5
{
    class Student
    {
        public string GetStudentName()
        {
            City.MySchool.Class.Student stu = new City.MySchool.Class.Student();
            return stu.name;
        }
    }
}
