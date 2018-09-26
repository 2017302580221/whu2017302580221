using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Program
    {
        public  abstract class Shape
        {
            private string myId;

            public Shape(string s)
            {
                Id = s;
            }

            public string Id
            {
                get
                {
                    return myId;
                }
                set
                {
                    myId = value;
                }
            }

            public abstract double Area { get; }

            public virtual  void Draw()
            {
                Console.WriteLine("Draw Shape Icon");
            }

            public override string ToString()
            {
                return Id + "Area = " + string.Format("{0:F2}", Area);
            }
        }

        public class Square : Shape
        {
            private double mySide;

            public Square (double side,string id) : base(id)
            {
                mySide = side;
            }

            public override double Area
            {
                get
                {
                    return mySide * mySide;
                }
            }

            public override void Draw()
            {
                Console.WriteLine("Draw 4 Side:" + mySide);
            }
        }

        public class Circle : Shape
        {
            private double myRadius;

            public Circle(double radius, string id) : base(id)
            {
                myRadius = radius ;
            }

            public override double Area
            {
                get
                {
                    return myRadius * myRadius * System.Math.PI;
                }
            }

            public override void Draw()
            {
                Console.WriteLine("Draw Circle:" + myRadius);
            }
        }

        public class Rectangle : Shape
        {
            private double myWidth;
            private double myHeight;

            public Rectangle(double width, double height, string id) : base(id)
            {
                myWidth = width;
                myHeight = height;
            }

            public override double Area
            {
                get
                {
                    return myWidth * myHeight;
                }
            }

            public override void Draw()
            {
                Console.WriteLine("Draw Rectangle");
            }
        }
        static void Main(string[] args)
        {
            Shape[] shapes = 
                {
                new Square (4.2,"Square"),
                new Circle(4.1,"Circle"),
                new Rectangle(4,5,"Rectangle")
            };

            foreach(Shape s in shapes)
            {
                System.Console.WriteLine(s);
            }
        }
    }
}
