using NUnit.Framework;
using LoliScriptCoreLib;
using LoliScriptCoreLib.Types;
using LoliScriptCoreLib.Statments;

namespace LoliScriptCoreLib.Test
{
    public class ExpressionUndStatmentsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ExpressionValueTest1()
        {
            Expression<int> oneExpr = new Expression<int>(1);
            int one = 1;
            Assert.AreEqual(one, oneExpr.Eval());
        }

        [Test]
        public void AddStatmentTest()
        {
            Expression<LoliInt> addExpr = new Expression<LoliInt>(new AddStatment(), 2, 2);
            LoliInt result = 4;
            Assert.AreEqual(result, addExpr.Eval());
        }

        [Test]
        public void AddUndMulTest()
        {
            Expression<LoliInt> add 
                = new  Expression<LoliInt>(
                    new AddStatment(), 
                    new Expression<LoliInt>(new MulStatment(), 3, 4),  
                    new Expression<LoliInt>(new MulStatment(), 1, 2));
            LoliInt result = 14;
            Assert.AreEqual(result.Value, add.Eval().Value);
        }

        [Test]
        public void IfStatment()
        {
            Expression<LoliInt> ifExpr 
                = new Expression<LoliInt>(
                        new IfStatment(
                            new BoolExpression<LoliInt>(
                                new EqStatment(), 
                                new Expression<LoliInt>(1), 
                                new Expression<LoliInt>(1))),
                        new Expression<LoliInt>(new AddStatment(), 2, 2),
                        new Expression<LoliInt>(new MulStatment(), 2, 4));

           Assert.AreEqual(ifExpr.Eval().Value, 4);
        }
    }
}
