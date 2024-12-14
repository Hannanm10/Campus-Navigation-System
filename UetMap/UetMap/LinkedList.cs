using System;
using System.Collections;
using System.Collections.Generic;

namespace UetMap
{
    public class List<T> : IEnumerable<T>
    {
        private class Node
        {
            public T Data;
            public Node Next;

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head;

        // Default constructor
        public List()
        {
            head = null;
        }

        // Constructor to initialize the list with another collection
        public List(IEnumerable<T> collection)
        {
            head = null;
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        // Add an item to the linked list
        public void Add(T data)
        {
            var newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var current = head;
                while (current.Next != null)
                    current = current.Next;
                current.Next = newNode;
            }
        }

        // Remove an item from the linked list
        public bool Remove(T data)
        {
            if (head == null)
                return false;

            if (head.Data.Equals(data))
            {
                head = head.Next;
                return true;
            }

            var current = head;
            while (current.Next != null && !current.Next.Data.Equals(data))
                current = current.Next;

            if (current.Next == null)
                return false;

            current.Next = current.Next.Next;
            return true;
        }

        // Check if an item exists in the linked list
        public bool Contains(T data)
        {
            var current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        // Get the data at a specific index
        public T GetAt(int index)
        {
            var current = head;
            int count = 0;
            while (current != null)
            {
                if (count == index)
                    return current.Data;
                current = current.Next;
                count++;
            }
            throw new IndexOutOfRangeException("Index out of range.");
        }

        // Get the size of the list
        public int Count()
        {
            int count = 0;
            var current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        // Implement IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public void Sort(Comparison<T> comparison)
        {
            // If the list is empty or has only one item, there's nothing to sort
            if (head == null || head.Next == null)
                return;

            // Convert the linked list to an array or a List<T> to use the built-in sorting
            var items = new List<T>();
            var current = head;
            while (current != null)
            {
                items.Add(current.Data);
                current = current.Next;
            }

            // Sort the list using the provided comparison function
            items.Sort(comparison);

            // Rebuild the linked list with the sorted items
            head = null; // Clear the current list
            foreach (var item in items)
            {
                Add(item); // Add items back in sorted order
            }
        }



        public void Clear()
        {
            head = null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
