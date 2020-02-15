using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Parser
    {
        private IList<IExpression> parseTree = new List<IExpression>();
        public Parser(string s)
        {
            foreach (var token in s.Split(' '))
            {
                switch (token)
                {
                    case "+":
                        parseTree.Add(new TerminalExpression_Plus());
                    break;
                    case "-":
                        parseTree.Add(new TerminalExpression_Minus());
                    break;
                    default:
                        parseTree.Add(new TerminalExpression_Number(Int32.Parse(token)));
                    break;
                }
            }
        }

        public int Evaluate()
        {
            var context = new Stack<int>(); 
            
            foreach(var e in parseTree)
            {
                e.Interpret(context);
            }

            return context.Pop();
        }
    }
}
