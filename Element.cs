using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandBox
{
    class Element
    {
        public Element left = null, right = null;
        public int data = 0;

        public Element(int data = 0)
        {
            this.data = data;
        }

        public void print()
        {
            Console.WriteLine(
                "Current element:\n" +
                $"Data: {data}\n");
        }

    }
}
