using System;
namespace Batch34_day8
{
    public interface MyTalent
    {
        void perform();
    }

    class Dance:MyTalent
    {
        public void perform()
        {
            Console.WriteLine("Dance : Western");
        }
    }
    class Singing:MyTalent
    {
        public void perform()
        {
            Console.WriteLine("Singing : Carnatic");
        }
    }
    class Pg1_Interface
    {
        static void Main(string[] args)
        {
            MyTalent ob = new Dance();
            ob.perform();

            MyTalent ob1 = new Singing();
            ob1.perform();

        }
    }
}
