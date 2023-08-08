using MyDictionary;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            MyDictionarys<string> myDictionarys = new MyDictionarys<string>();
            myDictionarys.Add("one");
            myDictionarys.Add("two");
            myDictionarys.Add("three");

            Console.WriteLine("Number of Elements: " + myDictionarys.Lenght());
            myDictionarys.PrintElement();
        
        }
    }
}