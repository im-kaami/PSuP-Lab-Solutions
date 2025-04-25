# 🧪 Lab 02 – PSuP

This folder contains C# implementations of the **Lab 02** tasks from the Problem Solving using Programming (PSuP) course.

Each task is implemented using `#region` blocks inside a single file (`Lab02Solutions.cs`) for organized and collapsible navigation. The tasks primarily focus on control flow, loops, randomness, user input handling, and basic console interactions.

---

## 📋 Task List

### ✅ Task 1: Print Even Numbers from User Input
Ask the user for `N` positive integers and display only the even numbers between `0` and `N`.

---

### 🔒 Task 2: Password Authentication
Store a preset password. Prompt the user to enter it, allowing up to 3 attempts. Display an error message if all attempts fail.

---

### 🎲 Task 3: Random Number Match
Generate random numbers between 1–1000 until one matches a number the user provided. Show how many attempts were made.

---

### 🎯 Task 4: Roll a Six to Start (Game Simulation)
Simulate players rolling a dice to determine who gets a six to start the game. Repeat until someone rolls a six.

---

### 🤔 Task 5: Guess the Imagined Number
Let the user guess a predefined number. Provide hints (greater/less than) and count how many guesses were made.

---

### 🔢 Task 6: Number Properties Analyzer
Ask for a number `N` and:
- Tell if it’s **even or odd**.
- Count how many **positive divisors** it has.
- Identify if it’s a **prime or composite** number.

---

### ❗ Task 7: Factorial Calculator
Ask for a positive integer and compute its factorial:
Example: 5! = 5 × 4 × 3 × 2 × 1 = 120

---

### ✖️ Task 8: Multiplication Table
Print a multiplication table in a grid format (1 to 9), as shown in the lab document.

---

### ⏱️ Task 9: Countdown Timer
Create a timer that takes seconds as input and shows a `M:SS` countdown. Change screen color and beep at the end.

---

### 🔁 Task 10: Decimal to Binary Converter
Take a `uint` input and display its binary representation in 8-bit groups in big-endian format.

---

### 🎰 Task 11: One-Armed Robber Game
Create a slot machine–style game with:
- 100 credits to start.
- Bets adjusted with ⬆️⬇️ keys.
- Outcomes based on random numbers.
- Win multiplier based on matched digits.
- Ends on `Escape` or zero credits.

---

## 🛠 How to Run

1. Make sure you have the [.NET 6+ SDK](https://dotnet.microsoft.com/en-us/download).
2. From the root of this folder, create a console app and run the solution:

```bash
dotnet new console -o Lab02App
cp Lab02Solutions.cs Lab02App/Program.cs
cd Lab02App
dotnet run
