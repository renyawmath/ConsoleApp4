using System;

namespace ConsoleApp4
{
    abstract class Shape 
    { 
        public abstract double area();
        public abstract double perimeter();
        public abstract void ShowInfo();
    }
    class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double area() => Math.PI * radius * radius;
        public override double perimeter() => 2 * Math.PI * radius;

        public override void ShowInfo()
        {
            Console.WriteLine($"фигура: круг, радиус: {this.radius}, периметр: {perimeter}, длина окружности: {area}");
        }
       
    }
    class Rectangle : Shape
    {
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double area() => width * height;
        public override double perimeter() => 2 * (width + height);

        public override void ShowInfo()
        {
            Console.WriteLine($"фигура: прямоугольник, высота: {this.height}, ширина: {this.width}, периметр: {perimeter}, площадь: {area}");
        }
    }
    class Triangle : Shape 
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double area()
        {
            double per = perimeter() / 2;
            return Math.Sqrt(per * (per - a) * (per - b) * (per - c));
        }
        public override double perimeter() => a + b + c;

        public bool IsValid() => a + b > c && a + c > b && b + c > a;

        public override void ShowInfo()
        {
            Console.WriteLine($"фигура: треугольник");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("*** круг ***");
            Console.WriteLine("Введите радиус: ");
            double radius = double.Parse(Console.ReadLine());
            Shape circle = new Circle(radius);
            circle.ShowInfo();

            Console.WriteLine("\n *** прямоугольник ***");
            Console.WriteLine("Введите ширину: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту: ");
            double height = double.Parse(Console.ReadLine());
            Shape rectangle = new Rectangle(width, height);
            rectangle.ShowInfo();

            Console.WriteLine("\n *** треугольник ***");
            Console.WriteLine("Введите первую сторону: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью сторону: ");
            double c = double.Parse(Console.ReadLine());
            Shape triangle = new Triangle(a, b, c);
            triangle.ShowInfo();
        }
    }
}

