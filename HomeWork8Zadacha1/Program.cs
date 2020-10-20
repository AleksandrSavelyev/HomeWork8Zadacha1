using System;

namespace HomeWork8Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point num = new Point();
            Console.Write("введите абциссу:\t");
            num.X = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите ординату:\t");
            num.Y = Convert.ToInt32(Console.ReadLine());

            num.GetPoint();
            num.GetDistance();
            num.GetQuarter();
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point()
        {
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void GetPoint()
        {
            Console.WriteLine($"точка находиться на абцисса:{X} ордината:{Y}");
        }
        public void GetDistance()
        {
            double distance = Math.Sqrt((X * X) + (Y * Y));
            Console.WriteLine(distance);
        }
        public void GetQuarter()
        {
            if (X > 0 && Y > 0)
                Console.WriteLine("I");
            else if (X < 0 && Y > 0)
                Console.WriteLine("II");
            else if (X < 0 && Y < 0)
                Console.WriteLine("III");
            else if (X > 0 && Y < 0)
                Console.WriteLine("IV");
            else
                Console.WriteLine("на оси");
            Console.ReadKey();
        }
    }
}
