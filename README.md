# Hidden Objects Game

[![C#](https://img.shields.io/badge/Language-C%23-239120?style=flat-square&logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/Framework-.NET%20Framework-512BD4?style=flat-square&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20%7C%20Cross--Platform-lightgray?style=flat-square)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-gray?style=flat-square)](LICENSE)

A console-based tactical grid search and hidden object puzzle game developed in C#. The player inspects a dynamically populated 20x20 grid to locate concealed multi-segment targets using coordinate targeting and spatial deduction.

---

## Game Mechanics & Rules

- **Grid Architecture:** A dynamic 20x20 matrix representing the active game board.
- **Hidden Targets:** 3 hidden multi-segment objects are randomly seeded across horizontal and vertical orientations without overlapping.
- **Colorized Terminal Rendering:**
  - `X` : Unexplored fog-of-war grid tile.
  - `1` (Green) : Successful target strike (+5 points).
  - `O` (Red) : Missed coordinate (-1 point).
- **Targeting System:** The user inputs Cartesian $(X, Y)$ coordinates for each turn.
- **Session Lifecycle:** The player has a quota of 100 turns. Final accuracy and aggregate score are computed and rendered upon session completion.

---

## Technical Architecture

```
HiddenObjectsGame/
├── HiddenObjectsGame.sln             # Solution configuration
└── HiddenObjectsGame/
    ├── App.config                    # Runtime application settings
    ├── HiddenObjectsGame.csproj      # C# project definition & dependencies
    └── Program.cs                    # Game loop, coordinate validation & ASCII renderer
```

### Core Logic Modules in `Program.cs`
- `player()`: Handles player initialization and username input.
- `draw_board()`: Color-coded ASCII buffer rendering loop.
- `fire()`: Interactive turn processor with input bounds checking.
- `matrix()`: Algorithmic procedural placement of objects onto the 20x20 grid.

---

## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) or [Visual Studio 2022](https://visualstudio.microsoft.com/) (with .NET desktop development workload).

### Installation & Run

1. Clone the repository:
   ```bash
   git clone https://github.com/furkanndev/HiddenObjectsGame.git
   cd HiddenObjectsGame
   ```

2. Build and run using the .NET CLI:
   ```bash
   dotnet build
   dotnet run --project HiddenObjectsGame/HiddenObjectsGame/HiddenObjectsGame.csproj
   ```

   *Alternatively, open `HiddenObjectsGame/HiddenObjectsGame.sln` directly in Visual Studio and press `F5`.*

---

## License

This project is licensed under the [MIT License](LICENSE).
