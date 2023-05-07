using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BildanovSharpikLabaTwelve
{
    internal class Class1
    {
        public class MyStack<T>
        {
            private T[] items;
            private int top;

            public MyStack(int size)
            {
                items = new T[size];
                top = -1;
            }

            public void Push(T item)
            {
                if (top == items.Length - 1)
                {
                    Console.WriteLine("Переполнение стека!");
                    return;
                }

                top++;
                items[top] = item;
            }

            public T Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Переполнение стека!");
                    return default(T);
                }

                T item = items[top];
                top--;
                return item;
            }

            public T Peek()
            {
                if (top == -1)
                {
                    Console.WriteLine("Стек пуст!");
                    return default(T);
                }

                return items[top];
            }

            public int Count()
            {
                return top + 1;
            }

            public string PrintStack()
            {
                string stackString = "";

                for (int i = top; i >= 0; i--)
                {
                    stackString += items[i].ToString() + "\n";
                }

                return stackString;
            }
        }
    }
}
