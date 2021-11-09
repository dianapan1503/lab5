using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть висоту конуса: ");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введіть радіус конуса: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                Conus conus = new Conus(height, radius);
                conus.InfoMethod();

                Console.WriteLine();
                Console.WriteLine("Зрізаний конус:");
                Console.WriteLine("Введіть радіус зрізаного конуса: ");
                double r2 = Convert.ToDouble(Console.ReadLine());
                Con2 con2 = new Con2(height, radius, r2);
                con2.InfoMethod();
            }
            catch
            {
                Console.WriteLine("З'явилось виключення");
            }
            Console.ReadLine();

        }
    }
    class Conus
    {
        public double Height { get; set; }
        public double Radius { get; set; }

        public Conus(double h, double r)
        {
            this.Height = h;
            this.Radius = r;

        }
        public virtual double ConVolume()
        {
            double vol = (Math.PI * Math.Pow(Radius, 2) * Height) / 3;
            return vol;
        }
        public double ConArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }
        public virtual void InfoMethod()
        {
            Console.WriteLine($"Висота = {Height}, Радіус = {Radius}");
            Console.WriteLine($"Об'єм = {ConVolume()} , Площа = {ConArea()} ");
        }
    }
    class Con2 : Conus
    {
        public double Radius2 { get; set; }
        public Con2(double r, double h, double r2)
            : base(r, h)
        {
            this.Radius2 = r2;
        }

        public override double ConVolume()
        {
            double vol1 = Math.PI * Height * (Math.Pow(Radius, 2) + (Radius * Radius2) + Math.Pow(Radius2, 2));
            return vol1;
        }

        public override void InfoMethod()
        {
            Console.WriteLine($"Радіус 2 = {Radius2}");
            Console.WriteLine($"Об'єм = {ConVolume()}");
        }
    }

}
