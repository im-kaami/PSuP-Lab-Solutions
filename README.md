# PSuP-Lab-Solutions
A collection of my C# lab solutions for the Problem Solving using Programming (PSuP) course, organized by lab and task using collapsible #region blocks for clarity and convenience.
This document provides a template structure and guidelines for organizing and submitting your PSuP lab solutions in a Git repository using C#, with each lab’s tasks contained in a single .cs file using regions.


1. Repository Layout (Single-File with Regions)
   
![image](https://github.com/user-attachments/assets/ce20319a-5d8d-4b3b-ac7f-3dc6433a4784)


Inside each LabXXSolutions.cs file, use regions to separate each task:

    using System;

namespace PSuP.Lab01
{
    class Lab01Solutions
    {
        static void Main()
        {
            // You can call individual task methods here
            Task03();
            // …
        }

        #region Task03: Description of Task 3
        static void Task03()
        {
            // solution code for task 3
        }
        #endregion

        #region Task04: Description of Task 4
        static void Task04()
        {
            // solution code for task 4
        }
        #endregion

        // … more regions for tasks
    }
}

Single-file approach keeps all related tasks in one context and makes navigation easy via collapsible #region blocks.

**Lab-specific **README.md can document instructions, sample inputs/outputs, or how to run specific tasks.

2. Sample README.md (Root)
   # PSuP Lab Solutions

This repository contains my C# lab solutions for the PSuP course.
Each lab’s tasks are implemented in a single C# file using regions.

## Prerequisites
- .NET 6.0 SDK or later

## How to Use
1. Clone the repo:
   ```bash
   git clone https://github.com/<im-kaami>/PSuP-lab-solutions.git
   cd PSuP-lab-solutions

Navigate to a lab directory (e.g., lab01).

Build and run the combined solutions file:
dotnet new console -o LabApp
cp Lab01Solutions.cs LabApp/Program.cs
cd LabApp
dotnet run
