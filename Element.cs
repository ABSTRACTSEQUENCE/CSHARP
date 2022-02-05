using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandBox
{
    class Element<T> where T : IComparable<T>
    {
        public Element<T> left { get; set; }
        public Element<T> right { get; set; }
        public Element<T> parent { get; set; }
        public T data { get; set; }

        public Element(T data)
        {
            left = right = parent = null;
            this.data = data;
        }

        public void print()
        {
            Console.WriteLine(
                "Current element:\n" +
                $"Data: {data}\n");
        }
        public Element<T> search(T data)
        {
            if (this.data.Equals(data))
                return this;
            else
            {

                if (left != null)
                    return left.search(data);

                else if (right != null)
                    return right.search(data);

                else 
                    return new Element<T>(data);

            }
            
        }



    }
}
