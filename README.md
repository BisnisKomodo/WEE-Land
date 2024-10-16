<table>
  <tr>
    <td align="left" width="50%">
      <img width="100%" alt="gif1" src="https://github.com/user-attachments/assets/e9393cbe-b8da-4c58-ba02-4b47e3ae8244">
    </td>
    <td align="right" width="50%">
      <img width="100%" alt="gif2" src="https://github.com/user-attachments/assets/e5fffd6f-dcbb-4520-939f-b9a057346eb6">
    </td>
  </tr>
</table>

<p align="center">
  <img width="100%" alt="gif3" src="https://github.com/user-attachments/assets/b7e3ff6c-0b43-47db-b0dd-4e9a75e1f02e">
</p>

##  📜Scripts and Features

You are able to do so many stuff in the game like walking, running, building, crafting, shooting, hunting, and so much more thanks to tons of scripting has been implemented to the game

|  Script       | Description                                                  |
| ------------------- | ------------------------------------------------------------ |
| `BudgetManager.cs` | Responsible for in game money system use to buy buildings |
| `Interact.cs` | Responsible for in game interaction including open shop and building placement |
| `PlayerMovement.cs`  | Responsible for the player movement and differentiate a spendable land |
| `DayManager.cs`  | Responsible for random event appear everyday and day controller |
| `WelfareManager.cs`  | Responsible for controlling the citizen welfare in game |
| `etc`  | |

<br>


## 🔴About
WEE Land is a game that entirely forgoes combat system. Your main objective is to survive as long as possible maintaining the Welfare, Entertainment and Education meter for the citizen. You are given a limited budget to satisfy the need of the citizen. I create Citizen meter, Shop System, Budget system, Day system, Next day system and a random event which trigger every one day.Here's a small portion details about WEE Land development presented
<br>

## 🕹️Play Game
The game was built using Unity Engine. Play the game from https://bisniskomodo.itch.io/wee-land. 
<br>

## 👤Developer
- Nicholas Van Lukman (Game Programmer)
- Nathania Joscelind (Game Artist)
- Tengku Muhammad Baha'uddin (Game Designer)
<br>

## 📂Files description

```
├── Please Survives                   # Contain everything needed for WEE Land to works.
   ├── .vscode                        # Contains configuration files for Visual Studio Code (VSCode) when it's used as the code editor for the project.
      ├── extensions.json             # Contains settings and configurations for debugging, code formatting, and IntelliSense. This folder is related to Visual Studio Code integration.
      ├── launch.json                 # Contains the configuration necessary to start debugging Unity C# scripts within VSCode.                     
      ├── setting.json                # Contains workspace-specific settings for VSCode that are applied when working within the Unity project.
   ├── Assets                         # Contains every assets that have been worked with unity to create the game like the scripts and the art.
      ├── Art                         # Contains all the game art like the sprites, background, even the character.
      ├── Animation                   # Contains every animation clip and animator controller that played when the game start.
      ├── Sounds                      # Contains every sound used for the game like music and sound effects.
      ├── Scripts                     # Contains all scripts needed to make the gane get goings like PlayerMovement scripts.
      ├── Prefabs                     # Contains every pre-configured, reusable game object that you can instantiate (create copies of) in your game scene.
      ├── Scenes                      # Contains all scenes that exist in the game for it to interconnected with each other like MainMenu, Gameplay, etc
      ├── Lighting                    # Contains all the Universal Render Pipelines and all lighting for the game.
   ├── Packages                       # Contains game packages that responsible for managing external libraries and packages used in your project.
      ├── Manifest.json               # Contains the lists of all the packages that your project depends on and their versions.
      ├── Packages-lock.json          # Contains packages that ensuring your project always uses the same versions of all dependencies and their sub-dependencies.
   ├── Project Settings               # Contains the configuration of your game to control the quality settings, icon, or even the cursor settings
├── README.md                         # The description of WEE Land file from About til the developers and the contribution for this game.
```
<br>

## 🕹️Game controls

The following controls are bound in-game, for gameplay and testing.

| Key Binding       | Function          |
| ----------------- | ----------------- |
| W,A,S,D           | Standard movement |
| E             | Open Shop/Interact              |
| Left Click             | Buy           |
| R             | Sell             |

<br>
