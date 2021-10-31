using System;

namespace Labb_1_Grunderna_i_OOP
{
    public class Circle
    {
        public double Radius;
        public double Pi = 3.14159265359;

        public Circle() : this(1, 3.14159265359)
        {
        }

        public Circle(double Radius, double Pi)
        {
            this.Radius = Radius;
            this.Pi = Pi;
        }

        public double getArea()
        {
            //double area = Radius * Radius * Pi;
            //Console.WriteLine("Area: " + area);
            return Radius * Radius * Pi;
        }
        public void getCircumference()
        {
            double circumference = 2 * Pi * Radius;
            Console.WriteLine("Omkrets: " + circumference);
        }
        public void getVolume()
        {
            double powThree = Math.Pow(Radius, 3);
            double volume = (4 * Pi * powThree) / 3;
            Console.WriteLine("Volym: " + volume);
        }
    }
    public class Triangle
    {
        public double Pi = 3.14159265359;
        public double TriBase;
        public double TriHeight;

        public Triangle() : this(3.14159265359, 5, 5)
        {
        }

        public Triangle(double Pi, double TriBase, double TriHeight)
        {
            this.Pi = Pi;
            this.TriBase = TriBase;
            this.TriHeight = TriHeight;
        }

        public void getArea()
        {
            double area = (TriBase * TriHeight) / 2;
            Console.WriteLine("Area: " + area);
        }
        public void getCircumference()
        {
            double circumference = (TriBase * 2) + (TriHeight * 2);
            Console.WriteLine("Omkrets: " + circumference);
        }
        public void getHypotenuse()
        {
            double powBase = Math.Pow(TriBase, 2);
            double powHeight = Math.Pow(TriHeight, 2);
            double hypotenuse = Math.Sqrt(powBase * powHeight);
            Console.WriteLine("Hypotenusan: " + hypotenuse);
        }
        public void getVolume()
        {
            double powBase = Math.Pow(TriBase, 2);
            double volume = (Pi * (powBase) * TriHeight) / 3;
            Console.WriteLine("Volymen för en kon är: " + volume);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cirkel med 5 i radie: ");
            Circle myCircle = new Circle();
            myCircle.Radius = 5;
            double area = myCircle.getArea();
            Console.WriteLine("Area: " + area);
            myCircle.getCircumference();
            myCircle.getVolume();

            Console.WriteLine("\nCirkel med 6 i radie: ");
            Circle myCircle2 = new Circle();
            myCircle2.Radius = 6;
            area = myCircle2.getArea();
            Console.WriteLine("Area: " + area);
            myCircle2.getCircumference();
            myCircle2.getVolume();

            Console.WriteLine("\nGör din egen cirkel:");
            Circle circle = new Circle();
            Console.Write("Skriv in vilken radie din cirkel ska ha: ");
            circle.Radius = double.Parse(Console.ReadLine());

            circle.getArea();
            circle.getCircumference();
            circle.getVolume();

            Console.WriteLine("\nGör din egen triangel: ");
            Triangle triangle = new Triangle();

            Console.Write("Skriv in basen på din rätvinkliga triangel: ");
            triangle.TriBase = double.Parse(Console.ReadLine());

            Console.Write("Skriv in höjden på din rätvinkliga triangel: ");
            triangle.TriHeight = double.Parse(Console.ReadLine());

            triangle.getArea();
            triangle.getCircumference();
            triangle.getHypotenuse();
            triangle.getVolume();
        }
    }
}
