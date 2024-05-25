# Hidden Objects Game

## Description
This project is a console-based hidden object game developed in C#. The goal is to find hidden objects in a 20x20 grid.

## Rules
- There are 3 hidden objects of varying lengths randomly placed in the grid.
- The objects are initially hidden and marked with an `X`.
- The player will be prompted to enter coordinates to find the hidden objects.
- If the entered coordinates hit any part of a hidden object, the player earns +5 points, and the spot is marked with a `1`. Otherwise, the player loses 1 point, and the spot is marked with a `0`.
- The game ends after 100 attempts.
- The final score is displayed at the end of the game.

## Usage
1. Clone this repository to your local machine:
    ```bash
    git clone https://github.com/yourusername/HiddenObjectsGame.git
    ```
2. Navigate to the project directory:
    ```bash
    cd HiddenObjectsGame
    ```
3. Open the project in Visual Studio or any other C# IDE.
4. Run the program.

## How to Play
- When the program starts, a 20x20 grid is created with hidden objects.
- The player is asked to input coordinates (row and column).
- The score is updated based on the input coordinates and the grid is displayed with the updated status.
- After 100 attempts, the game ends, and the final score is shown.

## Contribution
If you want to contribute, please fork the repository and submit a pull request. Any contributions and feedback are welcome.

## License
This project is licensed under the MIT License. See the `LICENSE` file for more information.
