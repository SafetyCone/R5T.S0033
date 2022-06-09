using System;


namespace R5T.S0033.Lib
{
    public static class Instances
    {
        public static B0006.ISyntaxGenerator SyntaxGenerator { get; } = B0006.SyntaxGenerator.Instance;
        public static ISyntaxGenerator SyntaxGenerator_Library { get; } = Lib.SyntaxGenerator.Instance;
        public static SyntaxTextConstants SyntaxTextConstants { get; } = new();
    }
}
