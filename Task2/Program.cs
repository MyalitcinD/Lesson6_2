using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] string_array = s.Split();
            string rev = "";
            s = "";
            foreach(string c in string_array) {
                s += c;
            }

            s = s.ToLower();

            foreach(char c in s) {

                rev = c + rev;
            }

            if(s == "") {
                Console.WriteLine("Строка пуста");
            }
            else if(rev == s) {
                Console.WriteLine("Строка палиндром");
            }
            else{
                Console.WriteLine("Строка НЕ палиндром");
            }
            //Console.WriteLine();
            Console.ReadKey();

        }
    }
}
