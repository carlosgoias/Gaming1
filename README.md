# Hi-Lo Game Engine

Welcome to the **Hi-Lo Game Engine** — a simple and fun number guessing game written in **C#**!  
Play solo or challenge your friends to guess the mystery number in as few attempts as possible.

## Game Rules

- The system randomly selects a **mystery number** between a minimum and maximum value (default: 1 to 10).
- Each player takes turns guessing the number.
- After each guess, the system tells you if the mystery number is:
  - **HI** ➔ The mystery number is higher than your guess
  - **LO** ➔ The mystery number is lower than your guess
- The first player to guess the correct number **wins**!

## Features

- **Single-player** and **Multiplayer** modes supported
- Tracks **number of attempts** per player
- Displays a **leaderboard**, highlighting the winner
- Handles invalid inputs gracefully
- Clean and extensible code structure:
  - `HiLoGameEngine` (handles the game logic)
  - `Player` (stores player information)

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/carlosgoias/Gaming1.git
   ```
2. Open the project in Visual Studio, Rider, or any C# IDE.
3. Build and run the project

Or run via CLI:
```bash
   dotnet run
```

## Example Gameplay

```
Welcome to the Multiplayer Hi-Lo Game!
Guess the mystery number between 1 and 10.

Enter number of players (at least 1): 2
Enter name for player 1: Alice
Enter name for player 2: Bob

Alice's turn. (1-10)
Enter your guess: 5
HI! The mystery number is higher.

Bob's turn. (1-10)
Enter your guess: 8
LO! The mystery number is lower.

...

Alice guessed the mystery number 7!

Leaderboard:
Alice: 3 attempts (Winner!)
Bob: 2 attempts
```
