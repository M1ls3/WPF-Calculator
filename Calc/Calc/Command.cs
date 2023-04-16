using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    abstract class Command
    {
        protected ArithmeticUnit unit;
        protected double operand;

        public abstract void Execute();
        public abstract void UnExecute();
    }


    class Add : Command
    {
        public Add(ArithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }

        public override void Execute()
        {
            try { unit.Run('+', operand); }
            catch { throw new NotImplementedException(); }
        }
        public override void UnExecute()
        {
            try { unit.Run('-', operand); }
            catch { throw new NotImplementedException(); }
        }

    }
    class Sub : Command
    {
        public Sub(ArithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }

        public override void Execute()
        {
            try { unit.Run('-', operand); }
            catch { throw new NotImplementedException(); }
        }
        public override void UnExecute()
        {
            try { unit.Run('+', operand); }
            catch { throw new NotImplementedException(); }
        }
    }
    class Mult : Command
    {
        public Mult(ArithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }

        public override void Execute()
        {
            try { unit.Run('*', operand); }
            catch { throw new NotImplementedException(); }
        }
        public override void UnExecute()
        {
            try { unit.Run('/', operand); }
            catch { throw new NotImplementedException(); }
        }
    }
    class Div : Command
    {
        public Div(ArithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }

        public override void Execute()
        {
            try { unit.Run('/', operand); }
            catch { throw new NotImplementedException(); }
        }
        public override void UnExecute()
        {
            try { unit.Run('*', operand); }
            catch { throw new NotImplementedException(); }
        }
    }
    class Sqrt : Command
    {
        public Sqrt(ArithmeticUnit unit)
        {
            this.unit = unit;
        }
        public override void Execute()
        {
            try { unit.Run('√'); }
            catch { throw new NotImplementedException(); }
        }
        public override void UnExecute()
        {
            try { unit.Run('^', 2); }
            catch { throw new NotImplementedException(); }
        }
    }
    class Pow : Command
    {
        public Pow(ArithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }
        public override void Execute()
        {
            try { unit.Run('^', operand); }
            catch { throw new NotImplementedException(); }
        }
        public override void UnExecute()
        {
            try { unit.Run('^', 1/operand); }
            catch { throw new NotImplementedException(); }
        }
    }
    class Ln : Command
    {
        public Ln(ArithmeticUnit unit)
        {
            this.unit = unit;
        }
        public override void Execute()
        {
            try { unit.Run('l'); }
            catch { throw new NotImplementedException(); }
        }
        public override void UnExecute()
        {
            try { unit.Run('^', unit.register); }
            catch { throw new NotImplementedException(); }
        }
    }
    class Exp : Command
    {
        public Exp(ArithmeticUnit unit)
        {
            this.unit = unit;
        }
        public override void Execute()
        {
            try { unit.Run('e'); }
            catch { throw new NotImplementedException(); }
        }
        public override void UnExecute()
        {
            try { unit.Run('l'); }
            catch { throw new NotImplementedException(); }
        }

    }
}
