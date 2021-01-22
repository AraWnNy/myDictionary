using System;
using System.Collections.Generic;
using System.Text;

namespace myDictionary
{
    class DictionaryModel<K,V>
    {
        private List<K> keyArray;
        private List<V> valueArray;
        

        public DictionaryModel()
        {
            keyArray = new List<K>();
            valueArray = new List<V>();
        }

        public void Add(K key, V value)
        {
            keyArray.Add(key);
            valueArray.Add(value);
        }

        public V Get(K key)
        {
            int Ix = keyArray.IndexOf(key);
            return valueArray[Ix];
        }
    }
}
