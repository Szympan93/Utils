using System;
using System.Collections.Generic;

namespace FunFact.Utils
{
    public static class DictionaryUtils
    {
        public static TValue GetOrCreate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key) where TValue : new()
        {
            if(!dictionary.TryGetValue(key, out var value)) dictionary.Add(key, value = new());
            return value;
        }
        
        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue @default) where TValue : new()
        {
            if(!dictionary.TryGetValue(key, out var value)) dictionary.Add(key, value = @default);
            return value;
        }
        
        public static TValue GetOrInit<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TValue> ctor) where TValue : new()
        {
            if(!dictionary.TryGetValue(key, out var value)) dictionary.Add(key, value = ctor());
            return value;
        }
    }
}