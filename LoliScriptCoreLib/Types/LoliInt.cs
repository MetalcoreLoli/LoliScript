using System;
using LoliScriptCoreLib.Operations;

namespace LoliScriptCoreLib.Types
{
    public readonly struct LoliInt : IAdd<LoliInt>, IMul<LoliInt>, IEq<LoliInt>
    {
        public readonly int Value { get; }

        public LoliInt(int value) => Value = value;

        public static  implicit operator int(LoliInt val) => val.Value;
        public static  implicit operator LoliInt(int val) => new LoliInt(val);

        public LoliInt Add(LoliInt right) => new LoliInt(this.Value + right.Value);

        public LoliInt Mul(LoliInt val) => new  LoliInt(this.Value * val.Value);

        public override bool Equals(object? obj)
        {
            if (obj is LoliInt val)
            {
                return this.Value == val.Value;
            }
            else return false;
        }

        public LoliBool Equal(LoliInt val) => Equals(val);
    }
}