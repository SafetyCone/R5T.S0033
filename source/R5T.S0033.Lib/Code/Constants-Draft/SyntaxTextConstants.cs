using System;

using R5T.T0131;


namespace R5T.S0033.Lib
{
    [DraftConstantsMarker]
    public class SyntaxTextConstants : IDraftConstantsMarker
    {

#pragma warning disable CA1822 // Mark members as static

        public string UsingSystem()
        {
            return "using System;";
        }
    }
}
