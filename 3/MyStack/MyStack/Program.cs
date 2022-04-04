using System;

namespace MyStack
{
    public class my_stack
    {
        int top = -1, size=5;
        int[] stack = new int[5];
        
        public bool Push(int data)
        {
            if (top >= size)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;

            }
        }
        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
            my_stack s = new my_stack();
            s.Push(5);
            s.Push(4);
            s.Push(3);
            s.Push(2);
            s.Push(1);
            s.PrintStack();
            s.Pop();
            s.Pop();
            s.PrintStack();
        }
        }
    }