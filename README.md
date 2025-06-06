# 🎰 Terminal Gambling Game

A console-based number-guessing betting game written in C# by **Nils Lyrevik** to learn .NET and C# basics.

## 🧠 Game Concept

You place a bet and try to guess a number that the computer has randomly picked. If your guess matches any of the numbers the computer selects, you win a payout based on how unlikely the match is. If not, you lose your bet. The game continues until you either choose to stop or run out of money.

## 🚀 How to Play

1. **Enter your name**.
2. **Choose a starting balance** (between 10 and 1000).
3. In each round:
   - Pick the **maximum number** for the guessing range (between 2 and 50,000).
   - Choose how many numbers the computer will randomly select from that range.
   - Place a bet (up to your current balance).
   - Enter your guess.
   - If your guess matches one of the computer’s numbers, you win a calculated payout.
4. After each round, you can choose to continue playing if you still have money.

## 💸 Payout Formula

The payout is calculated using this formula:

```
payout = (upperBound / numberOfComputerGuesses) * bet
```

This means the fewer guesses the computer gets (i.e. the harder it is for you to win), the higher your reward.

## 🛠️ Features

- Input validation to ensure values are within expected ranges.
- Continuous play loop until you’re broke or choose to quit.
- Dynamic payout based on game difficulty and bet size.
- Sleep delays to improve UX by spacing out messages.

## ✅ Requirements

- .NET SDK (e.g., .NET Core 3.1+ or .NET 5+)
- A terminal or console to run the app

## 🧪 How to Run

1. Save the code into a file named `TerminalGambling.cs`.
2. Open a terminal in the same directory.
3. Run the following commands:

```bash
dotnet new console -o TerminalGamblingGame
cd TerminalGamblingGame
# Replace the generated file with TerminalGambling.cs
mv ../TerminalGambling.cs Program.cs
dotnet run
```

## ✍️ Author

Created by Nils Lyrevik as part of learning C# and .NET programming.
