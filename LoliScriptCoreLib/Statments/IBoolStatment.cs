using LoliScriptCoreLib.Types;
namespace LoliScriptCoreLib.Statments
{
    public interface IBoolStatment
    {
        LoliBool Apply<T>(Expression<T> left, Expression<T> right);
    }
}
