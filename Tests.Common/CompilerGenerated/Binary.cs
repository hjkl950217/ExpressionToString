﻿using Xunit;
using static ExpressionToString.Tests.Categories;

namespace ExpressionToString.Tests {
    public partial class CompilerGeneratedBase {
        [Fact]
        [Trait("Category", Binary)]
        public void Add() {
            double x = 0, y = 0;
            RunTest(() => x + y, "() => x + y", "Function() x + y");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void AddChecked() {
            double x = 0, y = 0;
            RunTest(() => x + y, "() => x + y", "Function() x + y");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void Divide() {
            double x = 0, y = 0;
            RunTest(() => x / y, "() => x / y", "Function() x / y");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void Modulo() {
            double x = 0, y = 0;
            RunTest(() => x % y, "() => x % y", "Function() x Mod y");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void Multiply() {
            double x = 0, y = 0;
            RunTest(() => x * y, "() => x * y", "Function() x * y");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void MultiplyChecked() {
            double x = 0, y = 0;
            RunTest(() => x * y, "() => x * y", "Function() x * y");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void Subtract() {
            double x = 0, y = 0;
            RunTest(() => x - y, "() => x - y", "Function() x - y");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void SubtractChecked() {
            double x = 0, y = 0;
            RunTest(() => x - y, "() => x - y", "Function() x - y");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void AndBitwise() {
            int i = 0, j = 0;
            RunTest(() => i & j, "() => i & j", "Function() i And j");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void OrBitwise() {
            int i = 0, j = 0;
            RunTest(() => i | j, "() => i | j", "Function() i Or j");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void ExclusiveOrBitwise() {
            int i = 0, j = 0;
            RunTest(() => i ^ j, "() => i ^ j", "Function() i Xor j");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void AndLogical() {
            bool b1 = true, b2 = true;
            RunTest(() => b1 & b2, "() => b1 & b2", "Function() b1 And b2");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void OrLogical() {
            bool b1 = true, b2 = true;
            RunTest(() => b1 | b2, "() => b1 | b2", "Function() b1 Or b2");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void ExclusiveOrLogical() {
            bool b1 = true, b2 = true;
            RunTest(() => b1 ^ b2, "() => b1 ^ b2", "Function() b1 Xor b2");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void AndAlso() {
            bool b1 = true, b2 = true;
            RunTest(() => b1 && b2, "() => b1 && b2", "Function() b1 AndAlso b2");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void OrElse() {
            bool b1 = true, b2 = true;
            RunTest(() => b1 || b2, "() => b1 || b2", "Function() b1 OrElse b2");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void Equal() {
            int i = 0, j = 0;
            RunTest(() => i == j, "() => i == j", "Function() i = j");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void NotEqual() {
            int i = 0, j = 0;
            RunTest(() => i != j, "() => i != j", "Function() i <> j");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void GreaterThanOrEqual() {
            int i = 0, j = 0;
            RunTest(() => i >= j, "() => i >= j", "Function() i >= j");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void GreaterThan() {
            int i = 0, j = 0;
            RunTest(() => i > j, "() => i > j", "Function() i > j");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void LessThan() {
            int i = 0, j = 0;
            RunTest(() => i < j, "() => i < j", "Function() i < j");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void LessThanOrEqual() {
            int i = 0, j = 0;
            RunTest(() => i <= j, "() => i <= j", "Function() i <= j");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void Coalesce() {
            string s1 = null, s2 = null;
            RunTest(() => s1 ?? s2, "() => s1 ?? s2", "Function() If(s1, s2)");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void LeftShift() {
            int i = 0, j = 0;
            RunTest(() => i << j, "() => i << j", "Function() i << j");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void RightShift() {
            int i = 0, j = 0;
            RunTest(() => i >> j, "() => i >> j", "Function() i >> j");
        }

        [Fact]
        [Trait("Category", Binary)]
        public void ArrayIndex() {
            var arr = new string[] { };
            RunTest(() => arr[0], "() => arr[0]", "Function() arr(0)");
        }
    }
}
