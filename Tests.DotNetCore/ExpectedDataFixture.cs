﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressionToString.Util;
using static ExpressionToString.FormatterNames;
using static ExpressionToString.Tests.Functions;
using static System.Environment;
using static ExpressionToString.Util.Functions;
using System.IO;
using Xunit;

namespace ExpressionToString.Tests {
    public class ExpectedDataFixture : Dictionary<(string formatter, string objectName), string> {
        public ExpectedDataFixture() {
            foreach (var formatter in Runner.Formatters.Except(new[] { DebugView, "ToString" })) {
                var filename = formatter == CSharp ? "CSharp" : formatter;
                var expectedDataPath = GetFullFilename($"{filename.ToLower()}-testdata.txt");
                string testName = "";
                string expected = "";
                foreach (var line in File.ReadLines(expectedDataPath)) {
                    if (line.StartsWith("----")) {
                        if (testName != "") {
                            if (formatter == FactoryMethods) {
                                expected = FactoryMethodsFormatter.CSharpUsing + NewLines(2) + expected;
                            }
                            Add((formatter, testName), expected.Trim());
                        }
                        testName = line.Substring(5); // ---- typename.testMethod
                        expected = "";
                    } else {
                        expected += line + NewLine;
                    }
                }
            }
        }
    }

    [CollectionDefinition("Expected data from file")]
    public class FormatterTestCollection : ICollectionFixture<ExpectedDataFixture> { }
}
