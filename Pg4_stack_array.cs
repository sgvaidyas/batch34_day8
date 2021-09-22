using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day8
{
    class Pg4_stack_array
    {
        int max;
        int[] a;
        int top;

        Pg4_stack_array()
        {
            max = 5;
            a = new int[max];
            top = -1;
        }
                     
        void push()
        {
            if(top==max-1)
                Console.WriteLine("Stack overflow");
            else
            {
                Console.WriteLine("Element = ");
                int ele = int.Parse(Console.ReadLine());
                a[++top] = ele;
            }
        }
        void pop()
        {
            if(top==-1)
                Console.WriteLine("Stack underflow");
            else
            {
                Console.WriteLine("Deleting...."+a[top--]);//a[4]=55 top=3
            }
        }
        void display()
        {
            if(top==-1)
                Console.WriteLine("No elements in stack");
            else
            {
                Console.WriteLine("Stack elements");
                for(int i = top;i>=0 ;i--)
                    Console.WriteLine(a[i]);
            }
        }
        static void Main(string[] args)
        {
            int ch;
            Pg4_stack_array ob = new Pg4_stack_array();
            do
            {
                Console.WriteLine("1 PUSH\n2 POP\n3 DISPLAY\n4 EXIT");
                ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:ob.push();break;
                    case 2:ob.pop();break;
                    case 3:ob.display();break;
                    default: Console.WriteLine("invalid choice");break;
                }

            } while (ch!=4);
        }
    }
}
