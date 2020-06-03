using System;
using LoliScriptCoreLib.Operations;
using LoliScriptCoreLib.Statments;
using LoliScriptCoreLib.Types;

namespace LoliScriptCoreLib
{
    public class Expression<T>
    {
        public IStatment Statment { get; set; }
        public T Value  { get; private set; }
        public Expression<T> Left { get; set; }
        public Expression<T> Right { get; set; }

        public Expression(){}

        public Expression(T value)
        {
            Value = value;
        }

        public Expression(IStatment statment, Expression<T> left, Expression<T> right)
        {
            Statment = statment;
            Left = left;
            Right = right;
        }
        public Expression(IStatment statment, T left, T right) 
            : this(statment, new Expression<T>(left), new Expression<T>(right))
        {}

        public virtual T Eval()
        {
            if (Statment == null)
                return Value;
            else 
                return Statment.Apply(Left, Right);
        }
    }
}
