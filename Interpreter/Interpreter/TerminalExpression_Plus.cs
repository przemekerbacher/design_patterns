using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class TerminalExpression_Plus : IExpression
    {
        public void Interpret(Stack<int> s)
        {
            s.Push(s.Pop() + s.Pop());
        }
    }
}
