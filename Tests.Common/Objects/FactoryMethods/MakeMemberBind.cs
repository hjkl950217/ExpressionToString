﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using static ExpressionToString.Tests.Categories;
using static System.Linq.Expressions.Expression;
using static System.Reflection.BindingFlags;
using System.Linq;
using static ExpressionToString.Util.Functions;
using System.Reflection;

namespace ExpressionToString.Tests.Objects {
    internal class DummyMember {
        internal string Foo { get; set; }
    }

    partial class FactoryMethods {

        [Category(MemberBindings)]
        public static readonly MemberBinding MakeMemberBind = Bind(
            typeof(DummyMember).GetMember("Foo", Instance | NonPublic).Single(),
            Constant("abcd")
        );

        [Category(MemberBindings)]
        public static readonly ElementInit MakeElementInit = ElementInit(
            GetMethod(() => ((List<string>)null).Add("")),
            Constant("abcd")
        );

        [Category(MemberBindings)]
        public static readonly ElementInit MakeElementInit2Arguments = ElementInit(
            GetMethod(() => ((Wrapper)null).Add("", "")),
            Constant("abcd"),
            Constant("efgh")
        );

        [Category(MemberBindings)]
        public static readonly MemberBinding MakeMemberMemberBind = MemberBind(
            GetMember(() => ((Node)null).Data),
            Bind(
                GetMember(() => ((NodeData)null).Name),
                Constant("abcd")
            )
        );

        static readonly MethodInfo addMethod = GetMethod(() => ((IList<Node>)null).Add(new Node()));
        static readonly ConstructorInfo nodeConstructor = typeof(Node).GetConstructor(new Type[] { });

        [Category(MemberBindings)]
        public static readonly MemberBinding MakeListBinding = ListBind(
            GetMember(() => ((Node)null).Children),
            ElementInit(addMethod, New(nodeConstructor)),
            ElementInit(addMethod, New(nodeConstructor))
        );
    }
}