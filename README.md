# io-tag-parody
bring explicit IO tag checks to C# for the sake of purity 🦋

TL;DR usages of types/members decorated with `System.ObsoleteAttribute` in non-obsolete code cause 🔥compile-time🔥 warnings (or errors, if configured so)

Inspired by Haskell's `IO` type "tag" https://www.haskell.org/tutorial/io.html
