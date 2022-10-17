

- [Using](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement)
  - > Both using forms ensure that Dispose (or DisposeAsync) is called even if an exception occurs within the using block. You can achieve the same result by putting the object inside a try block and then calling Dispose (or DisposeAsync) in a finally block; in fact, this is how the using statement and the using declaration are translated by the compiler.
  - [Implement a DisposeAsync Method](https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-disposeasync)
  - Essentially sets lifetime boundaries on an object.


---

## Side Tangents

- [Service Locator is an Anti-Pattern](https://blog.ploeh.dk/2010/02/03/ServiceLocatorisanAnti-Pattern/)
  - > Using the `IServiceProvider` directly is an example of the service locator pattern This is generally considered an anti-pattern, as it hides a class' dependencies.
    - @R-GetService



---

# Time Analysis

- 1:00-ish Started
- 1:20-ish got distracted. Grabbed water, cheese stick, closed SM's, etc. about 10 min
- Onwards, followed tutorial; following several tangents (`using`, `IServiceProvider`, etc.)