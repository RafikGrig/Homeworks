using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multimap
{
    public class Multimap<K, V> : IDictionary<K, List<V>>
    {
        public Dictionary<K, List<V>> dict = new Dictionary<K, List<V>>();
        
        public List<V> this[K key] { get => dict[key]; set  { if(dict.ContainsKey(key)) dict[key] = value; } }

        public ICollection<K> Keys => dict.Keys;

        public ICollection<List<V>> Values => dict.Values;

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(K key, List<V> value)
        {
            
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<K, List<V>> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<K, List<V>> item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(K key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<K, List<V>>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<K, List<V>>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(K key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<K, List<V>> item)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(K key, out List<V> value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
