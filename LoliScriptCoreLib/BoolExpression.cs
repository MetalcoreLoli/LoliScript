using System;
using LoliScriptCoreLib.Operations;
using LoliScriptCoreLib.Statments;
using LoliScriptCoreLib.Types;

namespace LoliScriptCoreLib
{
    public class BoolExpression<T>  : Expression <LoliBool>
    {
        public new IBoolStatment Statment { get; set; }
        public new  Expression<T>  Left { get; set; }
        public new  Expression<T>  Right { get; set; }

        public BoolExpression(IBoolStatment statment, Expression<T> left, Expression<T> right)
        {
            Statment = statment;
            Left = left;
            Right = right;
        }

        public override LoliBool Eval()
        {
            if (Statment != null)
                return Statment.Apply(Left, Right);
            else 
                return false;
        }
    }
}
