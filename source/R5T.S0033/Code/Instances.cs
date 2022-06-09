using System;

using R5T.B0006;


namespace R5T.S0033
{
    public static class Instances
    {
        public static ISyntaxGenerator SyntaxGenerator { get; } = B0006.SyntaxGenerator.Instance;
        public static S0032.F001.ISyntaxOperator SyntaxOperator_FileOutput { get; } = S0032.F001.SyntaxOperator.Instance;
    }
}
