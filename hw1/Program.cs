using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                IntToString tmp = new IntToString();
                Console.WriteLine(tmp.PrintString(n));
            }
        }
    }
}
