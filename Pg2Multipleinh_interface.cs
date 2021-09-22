using System;

namespace Batch34_day8
{
    public interface Rectangle
    {
        void area();
        void perimeter();
    }
    public interface Circle
    {
        void area();
        void circum();
    }

    class Pg2Multipleinh_interface : Rectangle, Circle
    {
        int len, bred, rad;
        Pg2Multipleinh_interface()
        {
            Console.WriteLine("ENTER LEN , BRED, RAD");
            len = int.Parse(Console.ReadLine());
            bred = int.Parse(Console.ReadLine());
            rad = int.Parse(Console.ReadLine());

        }
        public void area()
        {
            Console.WriteLine("RECTANGLE AREA = "+(len*bred));
            Console.WriteLine("Circle AREA = " + (3.142* rad*rad));
        }

        public void circum()
        {
            Console.WriteLine("Circumference = "+2*3.142*rad);
        }

        public void perimeter()
        {
            Console.WriteLine("Perimeter = " + 2*(len+bred));
        }
        static void Main(string[] args)
        {
            Pg2Multipleinh_interface ob = new Pg2Multipleinh_interface();
            ob.area();
            ob.perimeter();
            ob.circum();
        }
    }
}
