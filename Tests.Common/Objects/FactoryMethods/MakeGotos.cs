﻿using System.Linq.Expressions;
using static ExpressionToString.Tests.Categories;
using static System.Linq.Expressions.Expression;

namespace ExpressionToString.Tests.Objects {
    partial class FactoryMethods {
        private static LabelTarget labelTarget = Label("target");

        [Category(Gotos)]
        public static readonly Expression MakeBreak = Break(labelTarget);

        [Category(Gotos)]
        public static readonly Expression MakeBreakWithValue = Break(labelTarget, Constant(5));

        [Category(Gotos)]
        public static readonly Expression MakeContinue = Continue(labelTarget);

        [Category(Gotos)]
        public static readonly Expression MakeGotoWithoutValue = Goto(labelTarget);

        [Category(Gotos)]
        public static readonly Expression MakeGotoWithValue = Goto(labelTarget, Constant(5));

        [Category(Gotos)]
        public static readonly Expression MakeReturn = Return(labelTarget);

        [Category(Gotos)]
        public static readonly Expression MakeReturnWithValue = Return(labelTarget, Constant(5));
    }
}
