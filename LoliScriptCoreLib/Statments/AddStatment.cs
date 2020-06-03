using System;
using LoliScriptCoreLib.Operations;

namespace LoliScriptCoreLib.Statments
{
    public class AddStatment : IStatment
    {
        public T Apply<T>(Expression<T> left, Expression<T> right)
        {
            T leftValue     = left.Eval();
            T rightValue    = right.Eval();
            if (leftValue is IAdd<T> lValue && rightValue is IAdd<T>)
                return lValue.Add(rightValue);
            else 
                throw new Exception("this expresstion does not support add operation !!!");
        }
    }
}
