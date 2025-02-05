﻿Imports ExpressionToString.Tests.Functions

Namespace Objects
    Partial Public Module VBCompiler
        <Category(Method)>
        Public InstanceMethod0Arguments As Expression = IIFE(Function()
                                                                 Dim s = ""
                                                                 Return Expr(Function() s.ToString())
                                                             End Function)

        <Category(Method)>
        Public StaticMethod0Arguments As Expression = Expr(Sub() DummyMethod())

        <Category(Method)>
        Public ExtensionMethod0Arguments As Expression = IIFE(Function()
                                                                  Dim lst = New List(Of String)()
                                                                  Return Expr(Function() lst.Distinct)
                                                              End Function)

        <Category(Method)>
        Public ExtensionMethod0ArgumentsWithoutConversion As Expression = IIFE(Function()
                                                                                   Dim lst As IEnumerable(Of String) = New List(Of String)()
                                                                                   Return Expr(Function() lst.Distinct)
                                                                               End Function)

        <Category(Method)>
        Public InstanceMethod1Argument As Expression = IIFE(Function()
                                                                Dim s = ""
                                                                Return Expr(Function() s.CompareTo(""))
                                                            End Function)

        <Category(Method)>
        Public StaticMethod1Argument As Expression = Expr(Function() String.Intern(""))

        <Category(Method)>
        Public ExtensionMethod1Argument As Expression = IIFE(Function()
                                                                 Dim lst = New List(Of String)()
                                                                 Return Expr(Function() lst.Take(1))
                                                             End Function)

        <Category(Method)>
        Public ExtensionMethod1ArgumentWithoutConversion As Expression = IIFE(Function()
                                                                                  Dim lst As IEnumerable(Of String) = New List(Of String)()
                                                                                  Return Expr(Function() lst.Take(1))
                                                                              End Function)

        <Category(Method)>
        Public InstanceMethod2Arguments As Expression = IIFE(Function()
                                                                 Dim s = ""
                                                                 Return Expr(Function() s.IndexOf("a"c, 2))
                                                             End Function)

        <Category(Method)>
        Public StaticMethod2Arguments As Expression = IIFE(Function()
                                                               Dim arr = New Char() {"a"c, "b"c}
                                                               Return Expr(Function() String.Join(","c, arr))
                                                           End Function)

        <Category(Method)>
        Public StaticMethod2ArgumentsWithoutConversion As Expression = IIFE(Function()
                                                                                Dim arr As IEnumerable(Of Char) = New Char() {"a"c, "b"c}
                                                                                Return Expr(Function() String.Join(","c, arr))
                                                                            End Function)

        <Category(Method)>
        Public ExtensionMethod2Arguments As Expression = IIFE(Function()
                                                                  Dim lst = New List(Of String)()
                                                                  Return Expr(Function() lst.OrderBy(Function(x) x, StringComparer.OrdinalIgnoreCase))
                                                              End Function)

        <Category(Method)>
        Public ExtensionMethod2ArgumentsWithoutConversion As Expression = IIFE(Function()
                                                                                   Dim lst As IEnumerable(Of String) = New List(Of String)()
                                                                                   Dim comparer As IComparer(Of String) = StringComparer.OrdinalIgnoreCase
                                                                                   Return Expr(Function() lst.OrderBy(Function(x) x, comparer))
                                                                               End Function)

        <Category(Method)>
        Public StringConcat As Expression = Expr(Function(s1 As String, s2 As String) String.Concat(s1, s2))

        <Category(Method)>
        Public StringConcatOperator As Expression = Expr(Function(s1 As String, s2 As String) s1 + s2)

        <Category(Method)>
        Public StringConcatOperatorParamArray As Expression = Expr(Function(s1 As String, s2 As String) s1 + s2 + s1 + s2 + s1 + s2)

        'This will not compile -- Like operator is currently not supported in .NET Core
        '<Category(Method)>
        'Public LikeOperatorStrings As Expression = Expr(Function(s1 As String, s2 As String) s1 Like s2)

        '<Category(Method)>
        'Public LikeOperatorObjects As Expression = Expr(Function(o1 As Object, o2 As Object) o1 Like o2)
    End Module
End Namespace
