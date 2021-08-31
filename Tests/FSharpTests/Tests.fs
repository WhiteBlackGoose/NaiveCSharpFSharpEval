module Tests

open System
open Xunit
open NaiveSharpEval

[<Fact>]
let ``F# Test 1`` () =
    let (success, res) = Executor.ExecuteFSharp "1 + 2"
    Assert.True success
    Assert.Equal("3", res)

[<Fact>]
let ``F# Test 2`` () =
    let code = """
let add a b = a + b
add 10 11
"""
    let (success, res) = Executor.ExecuteFSharp code
    Assert.True success
    Assert.Equal("21", res)

[<Fact>]
let ``C# Test 1`` () =
    let (success, res) = Executor.ExecuteCSharp "1 + 2"
    Assert.True success
    Assert.Equal("3", res)

[<Fact>]
let ``C# Test 2`` () =
    let code = """
Func<int, int, int> add = (a, b) => a + b;
add(10, 11)
"""
    let (success, res) = Executor.ExecuteCSharp code
    Assert.True success
    Assert.Equal("21", res)