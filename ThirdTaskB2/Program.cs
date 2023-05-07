using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ThirdTaskB2.Class1;

namespace ThirdTaskB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxQueue queue = new MaxQueue();
            using (StreamReader reader = new StreamReader("C:\\Users\\Coolsinee\\source\\repos\\BildanovSharpikLabaTwelve\\ThirdTaskB2\\B2.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    queue.Enqueue(line);
                }
            }

            Console.WriteLine("Максимальный элемент: " + queue.Max());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Максимальный элемент: " + queue.Max());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Максимальный элемент: " + queue.Max());
            Console.WriteLine("Enqueue: apple");
            queue.Enqueue("apple");
            Console.WriteLine("Максимальный элемент: " + queue.Max());
        }
    }
}
