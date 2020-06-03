namespace LoliScriptCoreLib.Statments
{
    public interface IStatment
    {
        T Apply<T>(Expression<T> left, Expression<T> right);
    }
}
