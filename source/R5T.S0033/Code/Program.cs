using System;
using System.Threading;
using System.Threading.Tasks;

using R5T.S0033.Lib;


namespace R5T.S0033
{
    class Program
    {        
        static Task Main()
        {
            Program.UsingNamespaceDirective();

            return Task.CompletedTask;
        }

#pragma warning disable IDE0051 // Remove unused private members

        private static void CompilationUnit01()
        {
            //var compilationUnit = Instances.SyntaxGenerator
        }

        private static void UsingNamespaceDirective()
        {
            var usingNamespaceDirective = Instances.SyntaxGenerator.UsingSystemNamespaceDirective();

            Instances.SyntaxOperator_FileOutput.WriteToExampleCodeFilePath(usingNamespaceDirective);
        }
    }
}