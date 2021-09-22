using System;

namespace Calculation
{
    class Calculator
    {
        int a, b;
        public Calculator()
        {
            Console.WriteLine("Input a and B");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }

        public void add()
        {
            Console.WriteLine("sum = "+(a+b));
        }
        public void mul()
        {
            Console.WriteLine("prod = " + (a * b));
        }
    }


    class Cal
    {
        int a, b;
        public Cal()
        {
            Console.WriteLine("Input a and B");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }

        public void sub()
        {
            Console.WriteLine("diff = " + (a - b));
        }
        public void div()
        {
            Console.WriteLine("quot = " + (a / b));
        }
    }
}


namespace Batch34_day8
{
    class pg3_Namespacedemo1
    {
        static void Main(string[] args)
        {
            Calculation.Calculator ob = new Calculation.Calculator();
            ob.add();
            ob.mul();

            Calculation.Cal ob2 = new Calculation.Cal();
            ob2.sub();
            ob2.div();


        }
    }
}
