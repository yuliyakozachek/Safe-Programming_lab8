using System;
using System.IO;
using System.Linq;

namespace Yuliya
{
    class Program
    {
        static double Rozrahunok(double r, Func<double,double> func)
        {
            return func(r);
        }
        static void Main(string[] args)
        {
            Console.Write("Радiус кола = ");
            double r = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(r);
            Func<double,double> func = circle.Dlina;
            Console.WriteLine("Довжина кола = "+Rozrahunok(r,func));
            func = circle.Ploshad;
            Console.WriteLine("Площа круга = "+Rozrahunok(r,circle.Ploshad));            
            func = circle.Obem;
            Console.WriteLine("Об'єм кулi = "+Rozrahunok(r,circle.Obem));
        }
    }
    class Circle
    {
        public double r;
        public Circle(double r)
        {
           this.r=r;
        }
        public double Dlina(double R)
        {
            return Math.Round(2*Math.PI*R,2);
        }
        public double Ploshad(double R)
        {
            return Math.Round(Math.PI*Math.Pow(R,2),2);
        }
        public double Obem(double R)
        {
            return Math.Round((4*Math.PI*Math.Pow(R,3))/3,2);
        }
    }
}