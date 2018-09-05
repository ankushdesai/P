﻿using Microsoft.Pc.TypeChecker.AST.Declarations;

namespace Microsoft.Pc.Backend.Solidity
{
    internal class CompilationContext : CompilationContextBase
    {
        public PSNameManager Names { get; }

        public CompilationContext(ICompilationJob job)
            : base(job)
        {
            Names = new PSharpNameManager("PGEN_");

            FileName = $"{ProjectName}.cs";
            GlobalFunctionClassName = $"GlobalFunctions_{ProjectName}";
        }

        public string GetStaticMethodQualifiedName(Function function)
        {
            return $"{GlobalFunctionClassName}.{Names.GetNameForDecl(function)}";
        }

        public string GlobalFunctionClassName { get; }

        public string FileName { get; }

    }
}
