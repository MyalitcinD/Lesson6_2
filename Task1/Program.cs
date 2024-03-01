using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] string_array = s.Split();
            string res = string_array[0];
            foreach(string c in string_array) {
                if(c.Length > res.Length) {
                    res = c;
                }
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
