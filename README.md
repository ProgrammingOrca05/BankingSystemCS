# Banking System (C# Console App)

A simple C# console application that simulates a basic banking system.  
This project demonstrates core Object-Oriented Programming (OOP) concepts in a practical scenario.

---

## Features

- Create a bank account with an initial balance
- Deposit and withdraw money
- Prevent overdrawing through validation
- Track transaction history
- Display account statement
- Change bank name (shared across all accounts)

---

## Concepts Used

- Encapsulation (private balance field)
- Static members (shared bank name)
- Classes and Objects
- Collections (`List<T>` and `ReadOnlyCollection<T>`)
- Validation (guard clauses)

---

## Project Structure

- `Program.cs` → Main menu and user interaction  
- `BankAccount.cs` → Core banking logic  
- `Transaction.cs` → Transaction model  
- `Transactions.cs` → Additional transaction handling (if applicable)

---

## How to Run

```bash
dotnet run
