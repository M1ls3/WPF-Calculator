using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculator
    {
        public ArithmeticUnit arithmeticUnit;
        public ControlUnit controlUnit;

        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }

        private double Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.register;
        }

        public double Add(double operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }
        public double Sub(double operand)
        {
            return Run(new Sub(arithmeticUnit, operand));
        }
        public double Mult(double operand)
        {
            return Run(new Mult(arithmeticUnit, operand));
        }
        public double Div(double operand)
        {
            return Run(new Div(arithmeticUnit, operand));
        }
        public double Sqrt()
        {
            return Run(new Sqrt(arithmeticUnit));
        }
        public double Pow(double operand)
        {
            return Run(new Pow(arithmeticUnit, operand));
        }
        public double Ln()
        {
            return Run(new Ln(arithmeticUnit));
        }
        public double Exp()
        {
            return Run(new Exp(arithmeticUnit));
        }

        public double Undo(int levels)
        {
            controlUnit.Undo(levels);
            return arithmeticUnit.register;
        }
        public double Redo(int levels)
        {
            controlUnit.Redo(levels);
            return arithmeticUnit.register;
        }
    }
}
