# Algorithmic Complexity #

## Timing Code ##
- [ ] Create some code that returns the time needed to execute a function.
- [ ] What if you make the array passed into the functions 10, 100, 1000, 10000 times bigger?
- [ ] Take down the times it takes to process different size of array, and use a spreadsheet utility to plot the results into a curve (time spent over input size).

The code below is a very simple way of timing how long it takes to run `Console.WriteLine("Hello World");`
```csharp
using System;

class MainClass {
  public static void Main (string[] args) {
    DateTime before = DateTime.Now;
    Console.WriteLine ("Hello World");
    DateTime after = DateTime.Now;
    Console.WriteLine (after - before);
  }
}

// OUTPUT

// Hello World
// 00:00:00.0770080
```
