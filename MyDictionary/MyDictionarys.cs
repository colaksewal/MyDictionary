using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionarys<T>
    {
        T[] words;

        public MyDictionarys()
        {
            words = new T[0];
        }

        public void Add(T value)
        {
            T[] tempWord = words;

            words = new T[words.Length + 1 ];

            for (int i = 0; i < tempWord.Length; i++)
            {
                words[i] = tempWord[i];
            }

            words[words.Length - 1 ] = value;
        }

        public int Lenght()
        {
            return words.Length;
        }

        public void PrintElement()
        {
            foreach (T value in words) {
                Console.WriteLine(value);
            }

        }
    }
}
