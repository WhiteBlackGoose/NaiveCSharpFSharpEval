# Naive # Eval

This package is only to test something. It synchronously evaluates C# or F# code and returns the string output if succeeded.

## Examples

### Call C# from C#

```cs
if (NaiveSharpEval.Executor.ExecuteCSharp("(double)(1 + 2)", out var res))
    Console.WriteLine(res);
else
    Console.WriteLine("Error!");
```

### Call F# from C#

```cs
if (NaiveSharpEval.Executor.ExecuteFSharp("(+) 1 2", out var res))
    Console.WriteLine(res);
else
    Console.WriteLine("Error!");
```

### Call C# from F#

```fs
match NaiveSharpEval.Executor.ExecuteCSharp "(double)(1 + 2)" with
| (true, res) -> printfn "%s" res
| _ -> printfn "%s" "Error!"
```

### Call F# from F#

```fs
match NaiveSharpEval.Executor.ExecuteFSharp "(+) 1 2" with
| (true, res) -> printfn "%s" res
| _ -> printfn "%s" "Error!"
```
