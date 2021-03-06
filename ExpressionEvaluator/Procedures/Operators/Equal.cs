﻿using Vanderbilt.Biostatistics.Wfccm2;

namespace ExpressionEvaluator.Procedures.Operators
{
    internal class Equal : Operator
    {
        public Equal(int precedance)
            : base("==", precedance, 2, false)
        {
            _name2 = "Equal";
            DecimalDecimalBool = (x, y) => x == y;
            BoolBoolBool = (x, y) => x == y;
            StringStringBool = (x, y) => x == y;
            TimespanTimespanBool = (x, y) => x == y;
            DatetimeDatetimeBool = (x, y) => x == y;
            ObjectObjectBool = (x, y) => x == y;
            AnyAnyBool = (x, y) => {
                if (x.GetType() != y.GetType()) {
                    return false;
                }
                throw new ExpressionException(_name2 + " unsupported type for comparison.");
            };
        }
    }
}
