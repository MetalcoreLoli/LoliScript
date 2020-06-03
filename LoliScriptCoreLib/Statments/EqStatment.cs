using System;
using LoliScriptCoreLib.Types;
using LoliScriptCoreLib.Operations;

namespace LoliScriptCoreLib.Statments
{
    public class EqStatment : IBoolStatment 
    {
        
        public LoliBool Apply<T>(Expression<T> left, Expression<T> right)
        {
            if (left.Eval() is IEq<T> lValue && right.Eval() is IEq<T>)
            {
                return lValue.Equal(right.Eval());
            }
            else 
                throw new Exception($"type {nameof(T)} is not supported equal operator !!!");
        }
    }
}
