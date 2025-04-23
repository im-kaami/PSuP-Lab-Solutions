# 💻 Lab 01 – Basic Programming Concepts

This lab introduces fundamental C# programming through console-based tasks, covering input/output, string handling, math operations, conditionals, cursor control, and basic logic. Each task is wrapped in `#region` blocks for clarity.

---

## ✅ Tasks Overview

### 1️⃣ Task 1 – Hello World
📢 Display "Hello, World!" on the screen. End the program when the user presses Enter.

---

### 2️⃣ Task 2 – Console Customization
🖥️ Modify the console using:
- `Console.Clear()`
- `Console.WindowWidth / WindowHeight`
- `Console.BackgroundColor`, `Console.ForegroundColor`
- `Console.SetCursorPosition()`, `Console.CursorVisible`

---

### 3️⃣ Task 3 – Greet by Name
👋 Ask for the user's name and greet them using their input.

---

### 4️⃣ Task 4 – Age Calculator
📅 Ask for the user's year of birth and display how old they will be next year.

---

### 5️⃣ Task 5 – BMI Calculator
⚖️ Input height (meters) and weight (kg), then compute BMI:

---

### 6️⃣ Task 6 – Time Formatter
⏱️ Convert seconds into `minutes:seconds` format (e.g., `123 → 2:03`).

---

### 7️⃣ Task 7 – Password Confirmation
🔐 Ask the user to enter a password twice and confirm if both entries match.

---

### 8️⃣ Task 8 – Hidden Password Input
🔒 Enhance password entry from Task 7:
- Show `*` instead of characters
- Allow deletion via Backspace

---

### 9️⃣ Task 9 – Arithmetic with Symbol
➗ Ask for two numbers and an operator, then perform the specified operation (`+`, `-`, `*`, `/`).

---

### 🔟 Task 10 – Two-Operand Expression Evaluator
🧠 Parse and compute expressions like: `18 / 3`, `4 * 5`.

---

### 1️⃣1️⃣ Task 11 – Full Expression Evaluator
📚 Evaluate properly bracketed expressions like:

---

### 1️⃣2️⃣ Task 12 – Number to Text
🔢 Ask for a number (0–9) and print its name in text (e.g., `9 → nine`).

---

### 1️⃣3️⃣ Task 13 – Tank Filling Problem
🚰 Given:
- Tank volume `V`
- Flow rates `R1`, `R2`
- Time `T`

Calculate how full the tank is after both pipes run for `T` hours:

---

## 🛠️ How to Run

1. Open `Lab01.cs` in Visual Studio or VS Code.
2. Use `#region` blocks to toggle each task on/off.
3. Run the program and interact via the terminal.

---

## 📌 Notes

- All inputs are read using `Console.ReadLine()`
- Outputs are displayed with `Console.WriteLine()`
- Tasks are modular and can be run/tested independently
