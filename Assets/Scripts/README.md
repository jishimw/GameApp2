# Maze Runner - Unity Project

This Unity project is a 3D maze game where the player controls a humanoid character in a third-person view. The goal is to navigate through the maze, collect keys to unlock doors, and reach the exit. The project includes a leaderboard to display the top 5 fastest players, along with a title screen and in-game pause menu for a smooth user experience.

## Features

- **Humanoid Player**: A 3D character controlled by the player in third-person view. I used a free door and key asset provided by Unity.
- **Third-Person Camera**: The camera follows the player, maintaining a consistent view of the character and environment.
- **Animated Movement**: The player displays a walk/run animation when moving.
- **Maze**: A 3D maze that includes an entrance, exit, and at least three doors requiring keys to open.
- **Key and Door System**: The player must find keys to unlock corresponding doors to progress. I used a free door and key asset provided by Unity.
- **Timer**: A UI timer that tracks the player's time to complete the maze.
- **Leaderboard**: At the end of each game, the player's time is recorded and displayed in a leaderboard showing the top 5 fastest times.
- **Title Screen**: A simple title screen with options to start the game, view the leaderboard, or exit.
- **In-Game Pause Menu**: Pressing `ESC` during the game opens a pause menu with options to restart the game or exit.

## Getting Started

### Prerequisites

- **Unity Editor**: The project was developed using Unity 2021 or later. Download it from the [official website](https://unity.com/).

### Installation

1. Clone the repository or download the project ZIP.
    ```bash
    git clone <repository_url>
    ```
2. Open the project in Unity by selecting the project folder through the **Unity Hub**.
3. Download any necessary assets from the Unity Asset Store if required.

### Controls

- **WASD / Arrow Keys**: Move the player character.
- **Mouse**: Rotate the camera around the player.
- **ESC**: Open the in-game pause menu.

## Game Flow

1. **Main Menu**: Start a new game, view the leaderboard, or quit the application.
2. **Maze Gameplay**:
   - Navigate through the maze using the movement controls.
   - Collect keys to open doors and progress towards the maze exit.
   - Complete the maze in the shortest time possible to rank on the leaderboard.
3. **Leaderboard**: After completing the maze, enter a 3-character name. Your time will be added to the leaderboard if it's one of the top 5 times.
4. **Restart**: Once the maze is completed, the game gracefully restarts, or you can restart from the pause menu.

## Scripts Overview

- **NameInputUI.cs**: Handles input of the player's name and displays the final score after completing the maze.
- **Leaderboard.cs**: Loads and displays the top 5 fastest players and their times.
- **PlayerPrefController.cs**: Saves and loads player data using Unity's `PlayerPrefs`.
- **MainMenu.cs**: Handles navigation between the main menu, leaderboard, and quitting the game.
- **Timer.cs**: Manages the in-game timer displayed in the UI during gameplay.

## Future Improvements

- **Improved Animations**: Add more polished animations for the player’s movement.
- **More Complex Mazes**: Implement procedurally generated mazes or larger, more challenging ones.
- **Multiple Levels**: Add additional levels or difficulty settings for more varied gameplay.

## Quit Functionality (Editor & Build)

In the **Main Menu**, the quit button:
- Stops play mode in the Unity Editor (`EditorApplication.isPlaying = false`).
- Quits the game in standalone builds (`Application.Quit()`).

## License

This project is for educational purposes.

---

**Developed By:**  
Joelle Ishimwe  