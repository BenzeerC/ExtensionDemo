using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            int result = c.Square(2);
            Console.WriteLine(result);

            int result1 = c.Multiply(4,3);
            Console.WriteLine(result1);

            
        }
    }
}
