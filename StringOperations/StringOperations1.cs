using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    public  class StringOperations1
    {
        public void Mymethod()
        {// join string
            string str1 = "C#";
            Console.WriteLine(str1);
            string str2 = "Programming";
            Console.WriteLine(str2);
            string joinString = String.Concat(str1, str2);
            Console.WriteLine( "the joined two string is:{0}",joinString);
            Console.ReadLine();
            // string length
            int length = str2.Length;
            Console.WriteLine("the length is:" + length);
            //compare two strings
            string str3 = "durga";
            string str4 = "durga";
            Boolean result = str3.Equals(str4);
            Console.WriteLine(result);
            // immutability of string objects
            string str = "hello";
            Console.WriteLine(str);
            // string interpolation
            string name = "program";
            string message =$"welcome to {name}";
            Console.WriteLine(message);
            //Escape sequence
            string str5 = "this is the \" string\"operations";
            Console.WriteLine("the escape sequence example is:\n" + str5);



        }
    }
}
