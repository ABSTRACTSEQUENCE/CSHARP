using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandBox
{
	class Tree
	{
		private Element root = null;

		public Tree(Element root = null)
		{
			this.root = root;
			Console.WriteLine($"Binary tree created");
		}

		public void Add(int data)
        {
			Add(data, root);
        }
		private void Add(int data, Element root)
		{
			if (this.root == null)
				this.root = new Element(data);
			else if(root.data > data)
            {
				if (root.left == null)
					root.left = new Element(data);
				else
					Add(data, root.left);
            }
			else if (root.data < data)
            {
				if (root.right == null)
					root.right = new Element(data);
				else
					Add(data, root.right);
			}

		}
		public void print()
        {
			print(root);
        }
		private void print(Element root)
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
			
				
			
		}//not done yet
		public void search(int data)
        {
			search(data, root);
        }
		public bool bool_search(int data)
        {
			return bool_search(data, root);
        }
		private void search(int data, Element root) //Данный метод баганный, т.к. дублирует код по 2 раза из за рекурсии, я не придумал как это предотвратить
		{
			if (this.root == null)
				Console.WriteLine("This tree is empty");
			else if (root.data == data)
			{
				Console.Write(
					$"Element with data {data} is found.\n" +
					$"Left element ");
				if (root.left != null)
					Console.Write($"= {root.left.data}\n");
				else if(root.left == null) 
					Console.WriteLine(" does not exist");

				Console.Write($"Right element ");
				if (root.right != null)
					Console.Write($"= {root.right.data}\n");
				else if(root.right == null) 
					Console.WriteLine(" does not exist");
			}
			else if (root.data != data)
            {
				if (root.left != null)
					search(data, root.left);
				if (root.right != null)
					search(data, root.right);
				else if (root.left == null && root.right == null)
				{
					Console.WriteLine($"Element with data {data} does not exist");
				}
            }
		}
		private bool bool_search(int data, Element root)
        {
			//Решил сделать ещё один search метод, который возвращает true если элемент найден и false если не найден
			if (this.root == null)
				return false;
			else
			{
				if (root.data == data)
					return true;
				else if (root.data != data)
				{
					if (root.left == null && root.right == null)
						return false;

					else if (root.left != null)
					{
						bool_search(data, root.left);
						return false;
					}
					else if (root.right != null)
					{
						bool_search(data, root.right);
						return false;
					}
				}
			}
        }
	}
}
