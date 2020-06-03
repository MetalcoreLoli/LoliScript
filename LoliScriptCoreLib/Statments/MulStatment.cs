using System;
using LoliScriptCoreLib.Operations;

namespace LoliScriptCoreLib.Statments
{
    public class MulStatment : IStatment
    {
        public T Apply<T>(Expression<T> left, Expression<T> right)
        {
            T leftValue     = left.Eval();
            T rightValue    = right.Eval();
            if (leftValue is IMul<T> lValue && rightValue is IMul<T>)
                return lValue.Mul(rightValue);
            else 
                throw new Exception("this expresstion does not support mul operation !!!");
        }
    }
}