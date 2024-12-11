using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_lineales_colas_
{
    internal class Queue
    {
        private Node front;
        private Node rear;
        private int size;

        public Queue()
        {
            front = rear = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void Enqueue(Node node)
        {
            if (rear == null)
            {
                front = rear = node;
            }
            else
            {
                rear.Next = node;
                rear = node;
            }
            size++;
        }

        public Node Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La cola está vacía.");

            Node temp = front;
            front = front.Next;

            if (front == null)
                rear = null;

            size--;
            return temp;
        }

        public Node Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La cola está vacía.");

            return front;
        }

        public int Size()
        {
            return size;
        }
    }

}

