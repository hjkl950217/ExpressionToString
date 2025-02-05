﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using static ExpressionToString.Tests.Functions;
using static ExpressionToString.Tests.Categories;
using static System.Linq.Expressions.Expression;
using static ExpressionToString.Tests.Globals;

namespace ExpressionToString.Tests.Objects {
    partial class FactoryMethods {

        [Category(Labels)]
        // we're using variables here to force explicit blocks, which have indentation
        // in order to verify that the label is written without indentation
        public static readonly Expression ConstructLabel = Block(
            new[] { i },
            Block(
                new[] { j },
                Constant(true),
                Label(Label("target")),
                Constant(true)
            )
        );

        [Category(Labels)]
        public static readonly Expression ConstructLabel1 = Block(
            new[] { i },
            Block(
                new[] { j },
                Label(Label("target")),
                Constant(true)
            )
        );

        [Category(Labels)]
        public static readonly LabelTarget ConstructLabelTarget = Label("target");

        [Category(Labels)]
        public static readonly LabelTarget ConstructEmptyLabelTarget = Label("");

    }
}