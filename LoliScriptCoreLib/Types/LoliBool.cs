using System;

namespace LoliScriptCoreLib.Types
{
    public readonly struct LoliBool 
    {
        public readonly bool Value { get; } 

        public LoliBool(bool val) => Value = val;
        public static implicit operator bool(LoliBool val) => val.Value;
        public static implicit operator LoliBool(bool val) => new LoliBool(val);
    }
}
