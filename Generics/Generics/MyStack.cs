using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyStack<T>
    {
        List<T> stack = new List<T>();
        int count = 0;

        public void Push(T Element)
        {
            this.stack.Add(Element);
            count = count + 1;
        }

        public T Pop()
        {
            T RemovedElement;
            T temp = default(T);

            if (count > 0)
            {
                RemovedElement = stack[count - 1];
                count--;
                return RemovedElement;
            }
            return temp;
        }

        public int Count { get { return count; } }
    }
}
