using System;
using System.Collections.Generic;
using System.Linq;

namespace UetMap
{
    class HashMap<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>>[] table; // Custom List class
        private int size;

        // Constructor with table size
        public HashMap(int size = 100)
        {
            this.size = size;
            table = new List<KeyValuePair<TKey, TValue>>[size];
            for (int i = 0; i < size; i++)
                table[i] = new List<KeyValuePair<TKey, TValue>>();
        }

        // Hash function to get index
        private int GetIndex(TKey key)
        {
            return Math.Abs(key.GetHashCode()) % size; // Ensure non-negative index
        }

        // Add or update a key-value pair
        public void Add(TKey key, TValue value)
        {
            int index = GetIndex(key);
            var bucket = table[index];

            // Update existing key
            foreach (var pair in bucket)
            {
                if (pair.Key.Equals(key))
                {
                    bucket.Remove(pair); // Remove old pair
                    bucket.Add(new KeyValuePair<TKey, TValue>(key, value)); // Add updated pair
                    return;
                }
            }

            // Add new key-value pair
            bucket.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        // Get value for a given key
        public TValue Get(TKey key)
        {
            int index = GetIndex(key);
            var bucket = table[index];

            foreach (var pair in bucket)
            {
                if (pair.Key.Equals(key))
                    return pair.Value;
            }

            throw new KeyNotFoundException($"Key '{key}' not found.");
        }

        // Check if a key exists
        public bool ContainsKey(TKey key)
        {
            int index = GetIndex(key);
            var bucket = table[index];

            foreach (var pair in bucket)
            {
                if (pair.Key.Equals(key))
                    return true;
            }
            return false;
        }

        // Remove key-value pair
        public bool Remove(TKey key)
        {
            int index = GetIndex(key);
            var bucket = table[index];

            foreach (var pair in bucket)
            {
                if (pair.Key.Equals(key))
                {
                    bucket.Remove(pair);
                    return true;
                }
            }
            return false;
        }

        // Clear all key-value pairs
        public void Clear()
        {
            for (int i = 0; i < size; i++)
                table[i] = new List<KeyValuePair<TKey, TValue>>(); // Reset buckets
        }

        public IEnumerable<KeyValuePair<TKey, TValue>> GetAll()
        {
            foreach (var bucket in table)
            {
                foreach (var pair in bucket)
                {
                    yield return pair;
                }
            }
        }
    }
}
