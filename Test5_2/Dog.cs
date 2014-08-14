using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test5_2
{
    public class Animal
    {
        protected string name;
        protected int age;

        public Animal() { }

        public Animal(string str)
        {
            name = "无名";
            age = 0;
        }

        public string Eat()
        {
            return string.Format("Animal({0}): 我现在饿了，我要吃东西！", name);
        }
    }


    public class Dog : Animal
    {
        private string type;
        private string name;
        public Dog():base("cool")
        {
            type = "未知";
        }

        internal string GetMessage()
        {
            return string.Format("Dog({0}):我的品种是{1},今年{2}岁了", name, type, age);
        }

    }
}
