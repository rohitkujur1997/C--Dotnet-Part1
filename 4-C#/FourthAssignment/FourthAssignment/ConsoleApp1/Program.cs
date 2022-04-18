﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthAssignment
{
    //Custom Exception Creation
    class StackException : Exception
    {
        public StackException(string message) : base(message)
        {
            //messeage already created in throw statement
        }
    }
    class MyStack : ICloneable
    {
        public int size { get; set; }
        protected int top;
        protected int[] array;


        public MyStack(int size)
        {
            this.size = size;
            array = new int[this.size];
            top = 0;

        }

        public void Push(int value)
        {
            if (!(top < size - 1))
            {
                throw new StackException("Stack is full.");
            }
            this.array[this.top] = value;
            top++;

        }

        public void Pop()
        {
            if (!(top > 0))
            {
                throw new StackException("Stack is empty.");
            }
            top--;
        }

        public void Display()
        {
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    class Program
    {
        //EXCEPTION HANDLING USING TRY,CATCH ,AND THROW
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter array Size:");
                int size = Convert.ToInt32(Console.ReadLine());
                MyStack stack = new MyStack(size);
                var clone = (MyStack)stack.Clone();
                Console.WriteLine("Enter values :");
                for (var i = 0; i < size; i++)
                {
                    int b = Convert.ToInt32(Console.ReadLine());
                    clone.Push(b);
                }
            }
            catch (StackException se)
            {
                Console.WriteLine(se.Message);
            }
            Console.ReadKey();
        }
    }
}