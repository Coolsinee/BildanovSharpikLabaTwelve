using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BildanovSharpikLabaTwevleSecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string input in File.ReadLines("C:\\Users\\Coolsinee\\source\\repos\\BildanovSharpikLabaTwelve\\BildanovSharpikLabaTwevleSecondTask\\Bebrik2.txt"))
            {
                Stack<char> stack = new Stack<char>();
                //Здесь я добавляю флаг balanced,
                //который по умолчанию равен true. Если встречается некорректная скобочная последовательность,
                //я просто устанавливаю balanced в false и выхожу из цикла. Если после проверки всех символов stack пуст и balanced равен true, вывожу "YES".
                //Если stack не пуст и balanced равен true, вывожу верхний элемент стека.
                bool balanced = true;

                for (int i = 0; i < input.Length; i++)
                {
                    char ch = input[i];

                    if (ch == '(' || ch == '[' || ch == '{')
                    {
                        stack.Push(ch);
                    }
                    else if (ch == ')' || ch == ']' || ch == '}')
                    {
                        if (stack.Count == 0)
                        {
                            Console.WriteLine(i + 1);
                            balanced = false;
                            break;
                        }

                        char top = stack.Pop();

                        if ((ch == ')' && top != '(') || (ch == ']' && top != '[') || (ch == '}' && top != '{'))
                        {
                            Console.WriteLine(i + 1);
                            balanced = false;
                            break;
                        }
                    }
                }

                if (stack.Count == 0 && balanced)
                {
                    Console.WriteLine("YES");
                }
                else if (stack.Count > 0 && balanced)
                {
                    Console.WriteLine(stack.Peek());
                }
            }

            Console.ReadKey();
        }
    }
}
