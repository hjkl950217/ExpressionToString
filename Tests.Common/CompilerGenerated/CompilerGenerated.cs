﻿using Xunit;
using static ExpressionToString.Tests.Globals;

namespace ExpressionToString.Tests {
    [Trait("Source", CSharpCompiler)]
    [Trait("Type", "Expression object")] // TODO ideally this would be on the base class, but https://github.com/xunit/xunit/issues/1397
    public abstract partial class CompilerGeneratedBase : TestsBase { }
}
