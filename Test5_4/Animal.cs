using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test5_4
{
    class Animal
    {
        protected string name;
        protected int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string Eat()
        {
            return String.Format("Animal({0}):  我现在饿了， 我要吃东西！", name);
        }
    }

    class Dog : Animal
    {
        private string type;

        public Dog(string name, int age, string type)
            : base(name, age)
        {
            this.type = type;
        }


        public sealed override string Eat()
        {
            return string.Format("Dog({0}): 我现在饿了，我要吃骨头！", name);
        }
    }

    class SmallDog : Dog
    {

        public SmallDog()
            :base("bb", 3, "hulala")
        {
        }
        public  string Eat()
        {
            return string.Format("SmallDog({0}): 我的小小狗狗！", name);
        }
    }
}
