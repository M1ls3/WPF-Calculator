using System;

namespace Calc
{
    internal class ArithmeticUnit
    {
        public double register { get;  set; }
        
        public void Run (char _operator, double _operand) 
        {
            switch (_operator)
            {
                case '+': register += _operand; break;
                case '-': register -= _operand; break;
                case '*': register *= _operand; break;
                case '/': register /= _operand; break;
                case '^': register = Math.Pow(register, _operand); break;
            }
        }
        public void Run(char _operator)
        {
            switch (_operator)
            {
                case '√': register = Math.Sqrt(register); break;
                case 'l': register = Math.Log10(register); break;
                case 'e': register = Math.Exp(register); break;
            }
        }
    }
}