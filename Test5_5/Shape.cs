using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test5_5
{
    // 定义抽象几何形状类
    abstract class Shape
    {
        protected const double PI = 3.14;
        protected double radius;
        public Shape() { }

        public Shape(double r)
        {
            radius = r;
        }

        public abstract double Cubage();
    }

    // 定义派生类 球体
    class Globe : Shape
    {
        public Globe(double r) : base(r) { }

        public override double Cubage()
        {
            return 3.14 * radius * radius * radius * 4.0 / 3; 
        }
    }

    // 定义派生类圆锥体
    class Cone : Shape
    {
        private double high;

        public Cone(double r, double h)
            : base(r)
        {
            high = h;
        }

        public override double Cubage()
        {
            return PI * radius * radius * high / 3;
        }
    }

    // 定义派生类圆柱体
    class Cylinder : Shape
    {
        private double high;
        public Cylinder(double r, double h)
            : base(r)
        {
            high = h;
        }

        public override double Cubage()
        {
            return PI * radius * radius * high;
        }
    }
}
