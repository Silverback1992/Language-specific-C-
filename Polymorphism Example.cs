using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tut_03
{
    abstract class Shape
    {
        public abstract double area(); 
    }

    class Circle : Shape
    {
        private double circleR;

        public Circle(double tempCircleR)
        {
            circleR = tempCircleR;
        }

        public override double area()
        {
            return circleR * circleR * 3.14;
        }
    }

    class Square : Shape
    {
        private double squareA;

        public Square(double tempSquareA)
        {
            squareA = tempSquareA;
        }

        public override double area()
        {
            return squareA * squareA;
        }
    }

    class Triangle : Shape
    {
        private double height;
        protected double theBase;

        public Triangle(double tempHeight, double tempTheBase)
        {
            height = tempHeight;
            theBase = tempTheBase;
        }

        protected Triangle(double tempTheBase)
        {
            theBase = tempTheBase;
        }

        public override double area()
        {
            return 0.5 * height * theBase;
        }
    }

    class RegularTriangle : Triangle
    {
        public RegularTriangle(double tempTheBase) : base(tempTheBase)
        {
            theBase = tempTheBase;
        }

        public override double area()
        {
            return (theBase * theBase * Math.Sqrt(3)) / 4;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapeObj = new Shape[5];

            shapeObj[0] = new Circle(4);
            shapeObj[1] = new Circle(5);
            shapeObj[2] = new Square(10);
            shapeObj[3] = new Triangle(3, 5);
            shapeObj[4] = new RegularTriangle(67);

            foreach (Shape i in shapeObj)
            {
                Console.WriteLine("An object of the {0} class. Its area is: {1}", i.GetType(), i.area());
            }

            Console.ReadKey();
        }
    }
}
