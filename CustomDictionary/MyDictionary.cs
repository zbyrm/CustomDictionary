using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDictionary
{
    
    class MyDictionary<TKey, TValue>
    {
        List<TKey> _keys;
        List<TValue> _values;

        public MyDictionary()
        {
            _keys = new List<TKey>();
            _values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            if (_keys == null)
                throw new  ArgumentNullException("key is null (key deger atanmamis)");

            if (_keys.Contains(key) )
            {
                //aynı keye sahip eleman var
                //An element with the same key already exists
                throw new ArgumentException("An element with the same key already exists (Anahtar degeri mevcut)");
            }

            _keys.Add(key);
            _values.Add(value);
        }

        public TValue this[TKey key] 
        {   
            get
            {
                int index = _keys.IndexOf(key);

                if (key==null)
                    throw new ArgumentNullException(" key is null (key deger atanmamis)") ;

                if (index == -1)
                    throw new KeyNotFoundException("key does not exist in the collection (Anahtar deger mevcut degil)");

                TValue value = _values[index];

                return value;
            }

        }
    }
}
