# Algorithmic Complexity #

## Timing Code ##
- [ ] Create some code that returns the time needed to execute a function.
- [ ] What if you make the array passed into the functions 10, 100, 1000, 10000 times bigger?
- [ ] Take down the times it takes to process different size of array, and use a spreadsheet utility to plot the results into a curve (time spent over input size).

_Example functions:_
* last
* reverse
* shuffle
* sort

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

The code below returns the time taken to run `Console.WriteLine("Hello World");` 10 times.
```csharp
using System;

class MainClass {
  public static void Main (string[] args) {
    for (var i = 0; i < 10; i++) {
      DateTime before = DateTime.Now;
      Console.WriteLine ("Hello World");
      DateTime after = DateTime.Now;
      Console.WriteLine (after - before);
    }
  }
}

// OUTPUT

// Hello World
// 00:00:00.0263560
// Hello World
// 00:00:00.0000090
// Hello World
// 00:00:00.0000080
// Hello World
// 00:00:00.0000070
// Hello World
// 00:00:00.0000070
// Hello World
// 00:00:00.0000080
// Hello World
// 00:00:00.0000070
// Hello World
// 00:00:00.0000060
// Hello World
// 00:00:00.0000240
// Hello World
// 00:00:00.0000070
```

### Stopwatch ###
**Namespace:** System.Diagnostics

The Stopwatch class is used to more accurately measure elapsed time as opposed to using `DateTime.now`

```csharp
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        Console.WriteLine("Hello World!");
        stopWatch.Stop();

        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
    }
}
```

The following two lines can be refactored further by using `Stopwatch.StartNew()` which will initialise the Stopwatch and start the timer at the same time.

```csharp
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
```

### TimeSpan ###
**Namespace:** System

The TimeSpan class represents a time interval. The resulting value of TimeSpan can be broken down into separate properties for formatting purposes; days, hours, minutes, seconds, milliseconds.

To return the total number of days, hours, minutes, seconds, or milliseconds, you can use the following methods:
* TotalDays
* TotalHours
* TotalMinutes
* TotalSeconds
* TotalMilliseconds
