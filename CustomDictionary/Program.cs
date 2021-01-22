using System;
using System.Collections.Generic;

namespace CustomDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(340, "Guven Gamsiz");
            

            Console.WriteLine(students[340]);

            MyDictionary<int, string> students2 = new MyDictionary<int, string>();
            students2.Add(83, "Mesut Bahtiyaroğlu");
            // students2.Add(83, "Saim Gelgör"); //ArgumentException  An element with the same key already exists

            Console.WriteLine(students2[83]);

        }
    }
}
