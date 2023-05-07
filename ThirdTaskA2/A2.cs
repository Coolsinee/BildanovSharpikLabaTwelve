using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTaskA2
{
    internal class A2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<char> queue = new Queue<char>();
            foreach (char c in input)
            {
                if (c >= 65 && c <= 90)
                { // 65-90 - ASCII коды заглавных латинских букв
                    queue.Enqueue(c);
                }
                else if (c == '*')
                {
                    if (queue.Count > 0)
                    {
                        Console.Write(queue.Dequeue() + " ");
                    }
                }
            }
        }
    }
}