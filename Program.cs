using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a reverse word test!!");

            var str = ReverseWord("Hello World!");
         
            if(str == "olleH !dlroW")
            {
                Console.Out.WriteLine("Correct");
            }
            else
            {
                Console.Out.WriteLine("Wrong");
            }
            Console.Out.WriteLine(str);
            Console.ReadLine();
        }

        private static String ReverseWord(string v)
        {
            var result = v.Split(' ');
            String finalResult = "";
            foreach (var item in result)
            {
                
                finalResult += ReverseString(item) + " ";
            }

            return finalResult.TrimEnd();
        }

        private static String ReverseString(string item)
        {
            String reverseResult = "";
            for (var i = item.Length-1; i >= 0; i--)
            {
                reverseResult += item[i];
            }

            return reverseResult;
        }
    }
}
