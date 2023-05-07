using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BildanovSharpikLabaTwelveThirdTask
{
    internal class ClassA1
    {
        class Queue
        {
            private char[] data;
            private int head;
            private int tail;
            private int count;
            private const int capacity = 100;

            public Queue()
            {
                data = new char[capacity];
                head = 0;
                tail = -1;
                count = 0;
            }

            public void Enqueue(char item)
            {
                if (count == capacity)
                {
                    throw new InvalidOperationException("Переполнение очереди");
                }
                tail = (tail + 1) % capacity;
                data[tail] = item;
                count++;
            }

            public char Dequeue()
            {
                if (count == 0)
                {
                    throw new InvalidOperationException("Переполнение очереди");
                }
                char item = data[head];
                head = (head + 1) % capacity;
                count--;
                return item;
            }
        }
    }
}
