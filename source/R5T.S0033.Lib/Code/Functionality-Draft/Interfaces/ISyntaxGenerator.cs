using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0132;


namespace R5T.S0033.Lib
{
    [DraftFunctionalityMarker]
    public partial interface ISyntaxGenerator : IDraftFunctionalityMarker
    {
        public UsingDirectiveSyntax UsingSystemNamespaceDirective()
        {
            var output = Instances.SyntaxGenerator.ParseUsingDirective(
                Instances.SyntaxTextConstants.UsingSystem());

            return output;
        }
    }
}
