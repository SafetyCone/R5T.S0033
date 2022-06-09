using System;


namespace R5T.S0033.Lib
{
    public class SyntaxGenerator : ISyntaxGenerator
    {
        #region Infrastructure

        public static SyntaxGenerator Instance { get; } = new();

        private SyntaxGenerator()
        {
        }

        #endregion
    }
}
