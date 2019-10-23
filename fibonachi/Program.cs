using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi {
    class Program {
        static void Main(string[] args) {
        int a = 1, b = 0, c = 1;
       int length = 1000;
        for(int i = 0; i < length;) {
        c = a + b;
        a = b;
        b = c;
        Console.WriteLine(c);
        Console.ReadLine();
        }
        }
        }
    }











