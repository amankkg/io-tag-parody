# io-tag-parody
bring explicit IO tag checks to C# for the sake of purity 🦋

TL;DR usages of types/members decorated with `System.ObsoleteAttribute` in non-obsolete code cause 🔥compile-time🔥 warnings (or errors, if configured so)

Example:
```csharp
using WithIO = System.ObsoleteAttribute; // fancy alias

void Pure()
{
  // ... any non-IO code
  Impure(); // error, `Impure` cannot be used here since `Pure` is not decorated with [WithIO]
}

[WithIO]
void Impure()
{
  // ... any IO code, interaction with filesystem || database || network etc.
}
```

Solution contains demo application, which is (intentionally) in compile error state.

Inspired by https://www.haskell.org/tutorial/io.html
