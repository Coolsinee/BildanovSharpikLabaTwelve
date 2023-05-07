using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTaskB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Чтение строк из файла и помещение их в очередь
            Queue<string> queue = new Queue<string>();
            using (StreamReader reader = new StreamReader("C:\\Users\\Coolsinee\\source\\repos\\BildanovSharpikLabaTwelve\\ThirdTaskB1\\B1.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    queue.Enqueue(line);
                }
            }

            // Поиск и перемещение наибольшей строки в начало очереди
            string maxString = "";
            foreach (string str in queue)
            {
                if (str.Length > maxString.Length)
                {
                    maxString = str;
                }
            }
            while (queue.Peek() != maxString)
            {
                string str = queue.Dequeue();
                queue.Enqueue(str);
            }

            // Вывод содержимого очереди
            foreach (string str in queue)
            {
                Console.WriteLine(str);
            }
        }
    }
}
