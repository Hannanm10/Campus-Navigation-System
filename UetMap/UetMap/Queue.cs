using System;
using System.Collections.Generic;

namespace UetMap
{
    public class Queue<T>
    {
        private List<T> list;

        // Constructor
        public Queue()
        {
            list = new List<T>();
        }

        // Add an item to the end of the queue
        public void Enqueue(T item)
        {
            list.Add(item);
        }

        // Remove and return the item at the front of the queue
        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");

            var item = list.GetAt(0);
            list.Remove(item);
            return item;
        }

        // Peek at the item at the front of the queue without removing it
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");

            return list.GetAt(0);
        }

        // Check if the queue is empty
        public bool IsEmpty()
        {
            return list.Count() == 0;
        }

        // Get the number of items in the queue
        public int Count()
        {
            return list.Count();
        }
    }
}
