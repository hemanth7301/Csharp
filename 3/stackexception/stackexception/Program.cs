using System;

namespace stackexception
{
    public class stackException: Exception{
        public stackException(string message) : base(message) {

        }
    }

    public class Stack
    {
        int top=-1;
        int[] stack = new int[5];

        bool IsEmpty()
        {
            return (top < 0);
        }
        public bool Push(int data)
        {
            if (top >= 4)
            {
                throw new stackException("Stack is full");
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
                throw new stackException("Stack is empty");
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        public void Peek()
        {
            if (top < 0)
            {
                throw new stackException("Stack is empty");
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }

        public void PrintStack()
        {
            if (top < 0)
            {
                throw new stackException("Stack is empty");
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
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();

        }
    }
}

