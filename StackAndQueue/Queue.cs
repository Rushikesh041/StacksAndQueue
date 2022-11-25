using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue
    {
        Node front;
        Node rear;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine($"{data} inserted into Queue");
        }
        public void Display()
        {

            int i = 1;
            int Size = 0;
            Node temp = front;

            Console.WriteLine();
            if (temp == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($"Element {i} in Stack is : " + temp.data);
                temp = temp.next;
                Size = i;
                i++;
            }
            Console.WriteLine($"\nTotal Elements in Stack is : {Size}\n");
        }
    }
}
