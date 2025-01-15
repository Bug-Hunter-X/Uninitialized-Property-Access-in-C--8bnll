# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property of a class before it's been initialized.  Uninitialized properties will contain default values (0 for integers, null for reference types) that can lead to unexpected behavior or exceptions, especially in calculations or comparisons.  The `Bug.cs` file showcases the issue; `BugSolution.cs` demonstrates the solution.

## How to reproduce:
1. Clone this repository.
2. Compile and run `Bug.cs`.  Observe the potential unexpected output.
3. Compare the output to that of `BugSolution.cs` for a more robust solution. 

## Solution:
Always initialize properties to prevent unexpected behavior. Consider initializing within the constructor or providing appropriate default values.