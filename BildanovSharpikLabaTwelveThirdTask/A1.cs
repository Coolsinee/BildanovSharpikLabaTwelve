using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BildanovSharpikLabaTwelveThirdTask.ClassA1;

namespace BildanovSharpikLabaTwelveThirdTask
{
    internal class A1
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue queue = new Queue();
            foreach (char c in input)
            {
                if (c >= 32 && c <= 127)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
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
}

