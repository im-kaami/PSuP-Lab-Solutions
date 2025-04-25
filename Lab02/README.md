# Lab 02 – PSuP Course

This folder contains C# implementations for the tasks in Lab 2 of the Programming and Systems Programming (PSuP) course.

## Structure

Each task is written inside a single file `Lab02Solutions.cs` using `#region` blocks for separation and clarity. You can collapse or expand each task in supported editors (like Visual Studio or VS Code).

## Tasks Overview

This lab focuses on basic operations using loops, arithmetic, and conditional logic in C#. Here's a list of the key task categories covered:

- **Task 1:** Display first 10 natural numbers.
- **Task 2:** Print a square of asterisks using nested loops.
- **Task 3:** Display multiplication table.
- **Task 4:** Calculate the sum of first `n` natural numbers.
- **Task 5:** Display number patterns using nested loops.
- **Task 6:** Count digits in an integer.
- **Task 7:** Reverse a number.
- **Task 8:** Check if a number is a palindrome.
- **Task 9:** Determine if a number is prime.
- **Task 10:** Generate a Fibonacci sequence.
- **Task 11:** Display all factors of a number.

> Each task starts with a comment explaining its purpose and any relevant inputs.

## How to Run

Ensure you have [.NET SDK](https://dotnet.microsoft.com/en-us/download) installed (version 6.0+ recommended):

```bash
dotnet new console -o Lab02App
cp Lab02Solutions.cs Lab02App/Program.cs
cd Lab02App
dotnet run
