# NaiveCSharpFSharpEval
This package is only to test something. It synchronously evaluates C# or F# code and returns the string output.

## Examples

### Call C# from C#

```cs
if (NaiveSharpEval.Executor.ExecuteCSharp("(double)(1 + 2)", out var res))
  Console.WriteLine(res);
```

### Call F# from C#

```cs
if (NaiveSharpEval.Executor.ExecuteFSharp("(+) 1 2", out var res))
  Console.WriteLine(res);
```

### Call C# from F#

```fs
open NaiveSharpEval
let (success, result) = Executor.ExecuteCSharp "(double)(1 + 2)"
```

### Call F# from F#

```fs
open NaiveSharpEval
let (success, result) = Executor.ExecuteFSharp "(+) 1 2"
```
