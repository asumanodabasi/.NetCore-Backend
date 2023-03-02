using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
   public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        //her seyin base i:object
        //object butun veri tiplerinin koleksiyonlarin base idir.
        void Add(string key, object value,int duraction); //duraction cache de ne kadar duracagini soyler
        bool IsAdd(string key); //cache de var mi diye bakcaz
        void Remove(string key);
        void RemoveByPattern(string pattern); //orn:icinde get olanlari sil
    
    }
}
