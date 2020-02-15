using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class TerminalExpression_Number : IExpression
    {
        private int _number;
        public TerminalExpression_Number(int number)
        {
            _number = number;
        }
        public void Interpret(Stack<int> s)
        {
            s.Push(_number); 
        }
    }
}
