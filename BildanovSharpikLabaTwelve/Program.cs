using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BildanovSharpikLabaTwelve.Class1;

namespace BildanovSharpikLabaTwelve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\Coolsinee\\source\\repos\\BildanovSharpikLabaTwelve\\BildanovSharpikLabaTwelve\\Bebrik1.txt");

            MyStack<string> stack = new MyStack<string>(lines.Length);

            foreach (string line in lines)
            {
                stack.Push(line);
            }

            Console.WriteLine(stack.PrintStack());

            string shortestString = stack.Peek();
            int shortestStringIndex = stack.Count();
            int shortestStringLength = shortestString.Length;

            for (int i = 0; i < stack.Count(); i++)
            {
                string currentString = stack.Pop();

                if (currentString.Length < shortestStringLength)
                {
                    shortestString = currentString;
                    shortestStringIndex = i + 1;
                    shortestStringLength = currentString.Length;
                }
            }
            Console.WriteLine($"Кратчайшая строка \"{shortestString}\" На позиции {shortestStringIndex} с длинной {shortestStringLength}.");
            Console.ReadKey();
        }
    }
}
