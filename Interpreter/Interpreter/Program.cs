using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "4 4 2 - +";
            var parser = new Parser(expression);
            
            Console.WriteLine($"{expression} = {parser.Evaluate()}");
            Console.ReadKey();
        }
    }
}
