using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTaskB2
{
    internal class Class1
    {
        public class MaxQueue
        {
            private Stack<string> stack1 = new Stack<string>();
            private Stack<string> stack2 = new Stack<string>();

            public void Enqueue(string str)
            {
                stack1.Push(str);
                if (stack2.Count == 0 || str.Length >= stack2.Peek().Length)
                {
                    stack2.Push(str);
                }
            }

            public string Dequeue()
            {
                if (stack1.Count == 0)
                {
                    throw new InvalidOperationException("Переполнение очереди");
                }
                string str = stack1.Pop();
                if (str == stack2.Peek())
                {
                    stack2.Pop();
                }
                return str;
            }

            public string Max()
            {
                if (stack2.Count == 0)
                {
                    throw new InvalidOperationException("Переполнение очереди");
                }
                return stack2.Peek();
            }
        }
    }
}
