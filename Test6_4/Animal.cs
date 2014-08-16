using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6_4
{
    public abstract class Animal
    {
        protected string name;
        public Animal(string na)
        {
            this.name = na;
        }

        public abstract string Eat();
    }

    public class Dog : Animal
    {
        public Dog(string na) : base(na) { }

        public override string Eat()
        {
            return string.Format("{0} : 我是Dog，我要吃骨头。", name);
        }
    }

    public class Cat : Animal
    {
        public Cat(string na) : base(na) { }

        public override string Eat()
        {
            return string.Format("{0} : 我是Cat，我要吃鱼。", name);
        }
    }

    public class SmallDog : Animal
    {
        public SmallDog(string na) : base(na) { }

        public override string Eat()
        {
            return string.Format("{0}: 我是SmallDog，我要吃狗粮。",name);
        }
    }

    public class Pet<T> where T : Animal
    {
        private List<T> animal = new List<T>();

        public List<T> Animal
        {
            get
            {
                return animal;
            }
        }

        public string FeedTheAnimals()
        {
            string msg = string.Empty;
            foreach (T ani in animal)
            {
                msg += "\n" + ani.Eat();
            }
            return msg;
        }
    }
}
