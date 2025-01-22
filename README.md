# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: attempting to access a property of a class before it has been assigned a value. This can lead to a `NullReferenceException`.

The `bug.cs` file contains the problematic code.  The `bugSolution.cs` file shows how to prevent this error by initializing the property.

## How to reproduce
1. Clone the repository.
2. Compile and run `bug.cs`.  You will observe a `NullReferenceException`.
3. Compile and run `bugSolution.cs`. The output will be `0`. 

## Solution
Always initialize your properties, especially in constructors, to prevent unexpected `NullReferenceException`.