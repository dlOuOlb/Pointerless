# Pointerless Ambiguity

There are many languages which do not reveal pointers directly to the programmers.

That is not a defect. That is an intentionally designed feature. But...

```csharp
var ValOrRef = new Quiz.StructOrClass();

Mutate(Who: ValOrRef);
```

Is that variable a value or a reference? Has it changed its internal state or not?

It depends on the context. Without pointer notation, it is not obvious at a [glance](./Codes/Program.cs) [#](http://github.com/dlOuOlb/Pointerless/blob/master/Codes/Program.cs).

One should [check](./Codes/Outside.cs) [#](http://github.com/dlOuOlb/Pointerless/blob/master/Codes/Outside.cs) whether the type is declared as plain-old-struct or nullable-class.

Yeah, passing by "ref" is a very trivial job, but it feels not that elegant...

Is there any better language design?
