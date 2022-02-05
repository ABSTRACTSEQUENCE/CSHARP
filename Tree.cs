using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandBox
{
	class Tree <T> where T : IComparable<T>
	{
		private Element<T> root = null;

		public Tree(Element<T> root = null)
		{
			this.root = root;
			Console.WriteLine($"Binary tree created");
		}

		public void Add(T data)
        {
			Add(data, root);
        }
		private void Add(T data, Element<T> root)
		{
			if (this.root == null)
				this.root = new Element<T>(data);
			else if(root.data.CompareTo(data) <0) 
            {
				if (root.left == null)
				{
					root.left = new Element<T>(data);
					root.left.parent = root;
				}
				else
					Add(data, root.left);
            }
			else if (root.data.CompareTo(data) > 0)
            {
				if (root.right == null)
				{
					root.right = new Element<T>(data);
					root.right.parent = root;
				}
				else
					Add(data, root.right);
			}

		}
		public void print()
        {
			print(root);
        }
		private void print(Element<T> root)
		{
			if (this.root == null)
				Console.WriteLine("Empty tree");
			else
			{
				Console.WriteLine(root.data);
				if (root.left != null)
                {
					print(root.left);
                }

				if (root.right != null)
                {
					
					print(root.right);

                }
			}
		}
		public Element<T> search(T data)
        {
			return root.search(data);
        }
		
	}
}
