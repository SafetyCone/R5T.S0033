using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;


namespace R5T.S0033.Lib
{
    public static class ISyntaxGeneratorExtensions
    {
        public static UsingDirectiveSyntax UsingSystemNamespaceDirective(this B0006.ISyntaxGenerator _)
        {
            var output = Instances.SyntaxGenerator_Library.UsingSystemNamespaceDirective();
            return output;
        }
    }
}
