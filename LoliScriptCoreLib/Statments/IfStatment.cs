using LoliScriptCoreLib.Types;

namespace LoliScriptCoreLib.Statments
{
    public class IfStatment : IStatment
    {
    
        public Expression<LoliBool> Condition { get; private set; } 

        public IfStatment(Expression<LoliBool> cond) => Condition = cond;

        public T Apply<T>(Expression<T> left, Expression<T> right)
        {
            if (Condition.Eval().Value) 
            {
                return left.Eval(); 
            } 
            else 
            {
                return right.Eval();
            }
        }
    }
}
