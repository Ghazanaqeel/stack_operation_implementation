using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            stack mystack = new stack();
            mystack.add(4);
            mystack.add(6);

            mystack.add(8);
            mystack.add(9);
            mystack.add(10);



            Console.WriteLine("pop element are");
            mystack.pop();
            mystack.pop();
            mystack.pop();
            Console.WriteLine("top element is");
            mystack.peek();
            Console.WriteLine("count are");
            mystack.count();
            Console.WriteLine("element in the stack are:");
            mystack.print();


        }
    }
    public class stack
    {
        int range = 5;
        int top;
        int[] stack1 = new int[5];


        public void add(int e)
        {
            if (top >= range)
            {
                Console.WriteLine("overflow");
            }
            else
            {
                stack1[top] = e;
                top++;
                Console.WriteLine(e);
            }
        }
        public void pop()
        {
            if (top < 0)
            {
                Console.WriteLine("underflow");
            }
            else
            {
                int x;
                x = stack1[top - 1];
                top = top - 1;

                Console.WriteLine(x);

            }
        }
        public void peek()
        {
            int y;
            y = stack1[top-1];
            Console.WriteLine(y);

        }
        public void count()
        {
            Console.WriteLine(top);
        }
        public void print()
        {
            Console.WriteLine("Items in the Stack are :");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack1[i]);
            }
        }
    }
}

