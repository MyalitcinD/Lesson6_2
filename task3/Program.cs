using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            int op = s.IndexOf('{'); int cl = s.IndexOf('}');
            string res = "";
            while(op != -1) {
                res = res + s.Substring(0, op);
                s = s.Remove(0, cl + 1);
                op = s.IndexOf('{');
                cl = s.IndexOf('}');
                //Console.WriteLine();
                //Console.WriteLine("s === " + s);
                //Console.WriteLine("-open = {0} close = {1}", op, cl);
                if((cl < op) || ((cl != -1) && (op == -1))) {
                    s = s.Remove(0, cl + 1);
                    cl = s.IndexOf('}');
                    op = s.IndexOf('{');
                }
                //Console.WriteLine("-open = {0} close = {1}", op, cl);
                //Console.WriteLine("res === " + res);
                //Console.WriteLine("s === " + s);
            }
            res = res + s;
            //Console.WriteLine();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
