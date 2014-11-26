namespace ExtractingArtists
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, V> : IEnumerable<KeyValuePair<K, V>>
    {
        const int InitialValuesSize = 16;

        LinkedList<KeyValuePair<K, V>>[] values;

        public HashTable()
        {
            this.values = new LinkedList<KeyValuePair<K, V>>[InitialValuesSize];
        }

        public void Add(K key, V value)
        {
            var hash = key.GetHashCode();

            hash %= this.Capacity;
            hash = Math.Abs(hash);

            if (this.values[hash] == null)
            {
                this.values[hash] = new LinkedList<KeyValuePair<K, V>>();
            }

            var alreadyHasKey = this.values[hash].Any(p => p.Key.Equals(key));

            if (alreadyHasKey)
            {
                throw new ArgumentException("Key already exists");
            }

            var pair = new KeyValuePair<K, V>(key, value);
            this.values[hash].AddLast(pair);
            this.Count++;

            if (this.Count >= 0.75 * this.Capacity)
            {
                this.ResizeAndReadValues();
            }
        }

        public void Clear()
        {
            values = new LinkedList<KeyValuePair<K, V>>[values.Length];
            this.Count = 0;
        }

        public void Remove(K key)
        {
            if (this.ContainsKey(key))
            {
                var hash = Math.Abs(key.GetHashCode()) % this.Capacity;
                var next = this.values[hash].First;
                while (next != null)
                {
                    if (next.Value.Key.Equals(key))
                    {
                        this.values[hash].Remove(next);
                        this.Count -= 1;
                    }
                    next = next.Next;
                }
            }
            else
            {
                throw new ArgumentException("There is no such key in the hash table");
            }
        }

        public V this[K key]
        {
            get
            {
                return this.Find(key);
            }
            set
            {
                var hash = Math.Abs(key.GetHashCode()) % this.Capacity;

                if (this.values[hash] == null)
                {
                    throw new ArgumentException("There is no such key");
                }
                else
                {
                    bool isFind = false;
                    var next = this.values[hash].First;
                    while (next != null)
                    {
                        if (next.Value.Key.Equals(key))
                        {
                            LinkedListNode<KeyValuePair<K, V>> node =
                                new LinkedListNode<KeyValuePair<K, V>>(new KeyValuePair<K, V>(key, value));
                            this.values[hash].AddAfter(next, node);
                            this.values[hash].Remove(next);
                            isFind = true;
                            break;
                        }
                        next = next.Next;
                    }
                    if (isFind == false)
                    {
                        throw new ArgumentException("There is no element with this key");
                    }
                }
            }
        }

        public V Find(K key)
        {
            var hash = Math.Abs(key.GetHashCode()) % this.Capacity;

            //this also works but is error prone
            //var pair = this.values[hash];
            //return pair.First.Value.Value;
            if (this.values[hash] == null)
            {
                throw new ArgumentException("There is no element with this key");
            }
            else
            {
                var next = this.values[hash].First;
                while (next != null)
                {
                    if (next.Value.Key.Equals(key))
                    {
                        return next.Value.Value;
                    }
                    next = next.Next;
                }
                throw new ArgumentException("There is no element with this key");
            }
        }

        public bool ContainsKey(K key)
        {
            var hash = Math.Abs(key.GetHashCode()) % this.Capacity;

            if (!(this.values[hash] != null))
            {
                return false;
            }

            var pair = this.values[hash];

            return pair.Any(p => p.Key.Equals(key));
        }

        public IList<K> Keys
        {
            get
            {
                var keys = new List<K>();

                for (int i = 0; i < this.values.Length; i++)
                {
                    if (this.values[i] != null)
                    {
                        var next = this.values[i].First;
                        while (next != null)
                        {
                            keys.Add(next.Value.Key);
                            next = next.Next;
                        }
                        
                    }
                }
                return keys;
            }
            private set { }
        }

        public int Count
        {
            get;
            private set;
        }

        public int Capacity
        {
            get
            {
                return this.values.Length;
            }
        }

        private void ResizeAndReadValues()
        {
            var cachedValues = this.values;
            this.values = new LinkedList<KeyValuePair<K, V>>[this.Capacity * 2];

            this.Count = 0;

            foreach (var valueCollection in cachedValues)
            {
                if (valueCollection != null)
                {
                    foreach (var value in valueCollection)
                    {
                        this.Add(value.Key, value.Value);
                    }
                }
            }
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            foreach (var valueCollection in this.values)
            {
                if (valueCollection != null)
                {
                    foreach (var value in valueCollection)
                    {
                        yield return value;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
