using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5._2
{
    internal abstract class Figure
    {
        internal abstract double Area();
    }

    internal class Circle : Figure
    {
        private double _radius;
        internal double Radius
        {
            get { return _radius; }
        }

        internal Circle(double ra)
        {
            this._radius = ra;
        }

        internal override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }

    internal class Rectangle : Figure
    {
        double _long;
        double _high;

        public double Long
        {
            get { return _long; }
        }
        public double High
        {
            get { return _high; }
        }

        public Rectangle(double lo, double hi)
        {
            this._long = lo;
            this._high = hi;
        }

        internal override double Area()
        {
            return Long * High;
        }
    }

    internal class Triangle : Figure
    {
        double _long;
        double _high;

        internal double Long
        {
            get { return _long; }
        }
        internal double High
        {
            get { return _high; }
        }

        internal Triangle(double lo, double hi)
        {
            _long = lo;
            _high = hi;
        }

        internal override double Area()
        {
            return Long * High / 2;
        }
    }



}
