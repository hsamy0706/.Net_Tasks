using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    internal class Cash<TKey,TValue>
    {
        private int maxSize=0;
        
        private Dictionary<TKey, TValue> items;
        private LinkedList<TKey> LRU;
        public Cash(int size)
        {
            maxSize = size;
            items = new Dictionary<TKey, TValue>();
            LRU = new LinkedList<TKey>();

        }
        public void Add(TKey key,TValue value)
        {
            if(items.Count == maxSize)
            {
                RemoveLeastRecentlyUsed();

            }
            if (items.ContainsKey(key))
            {
                LRU.Remove(key);
                LRU.AddFirst(key);
                items[key] = value;


            }
            else
            {
                LRU.AddFirst(key);
                items.Add(key, value);

            }
        }
        public KeyValuePair<TKey,TValue>? GetByKey(TKey key)
        {
            if (items.TryGetValue(key, out TValue value))
            {
                
                LRU.Remove(key);
                LRU.AddFirst(key);
                return new KeyValuePair<TKey, TValue>(key, value);
            }
            else
            {
                return null; // Not found
            }
        }
        public bool Remove(TKey key)
        {
            if (items.ContainsKey(key))
            {
                LRU.Remove(key);
                return items.Remove(key);


            }
            return false;
        }
        private void RemoveLeastRecentlyUsed()
        {
            var lruNode = LRU.Last;
            if (lruNode != null)
            {
                items.Remove(lruNode.Value);
                LRU.RemoveLast();
            }
        }
    }
}
