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

## 📜WEE Land Scripts Example (Interact)
```
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    private bool canInteract = false;
    private CanvasGroup shops;
    public GameObject Buildings;
    private BudgetManager budgetmanager;
    private WelfareManager welfaremanager;
    private EntertaintmentManager entertaintmentmanager;
    private EducationManager educationmanager;
    public int sellValue = 2;
    private PlayerMovement playermovement;

    void Start()
    {
        welfaremanager = FindObjectOfType<WelfareManager>().GetComponent<WelfareManager>();
        entertaintmentmanager = FindObjectOfType<EntertaintmentManager>().GetComponent<EntertaintmentManager>();
        educationmanager = FindObjectOfType<EducationManager>().GetComponent<EducationManager>();
        budgetmanager = FindObjectOfType<BudgetManager>().GetComponent<BudgetManager>();
        playermovement = FindObjectOfType<PlayerMovement>();
    }
    void Awake()
    {
        shops = GameObject.Find("Canvas/ShopMenu").GetComponent<CanvasGroup>();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            canInteract = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            canInteract = false;
        }
    }

    void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            shops.alpha = 1f;
            shops.blocksRaycasts = true;
            shops.interactable = true;
            playermovement.SetCanMove(false);
        }
    }

    public void EndInteraction()
    {
        shops.alpha = 0f;
        shops.blocksRaycasts = false;
        shops.interactable = false;
        playermovement.SetCanMove(true);
    }

    public void Builds(GameObject Building, int money, float welfaretoadd, float EntertaintmentToAdd, float educationadd, float welfarereduction, float entertaintmentreduction, float educationreduction)
    {
        if(Buildings != null)
        {
            Debug.Log("Building Occupied");
            budgetmanager.AddMoney(money);
            return;
        }
        Buildings = Instantiate(Building, transform.position, transform.rotation);
        welfaremanager.welfareincrease(welfaretoadd);
        entertaintmentmanager.entertaintmentincrease(EntertaintmentToAdd);
        educationmanager.educationincrease(educationadd);
        welfaremanager.welfarereduce(welfarereduction);
        entertaintmentmanager.entertaintmentreduce(entertaintmentreduction);
        educationmanager.educationreduce(educationreduction);
    }

    public void SellBuilding()
    {
        if (Buildings != null)
        {
            budgetmanager.AddMoney(sellValue);  // Add money for selling the building
            Destroy(Buildings);  // Destroy the building game object
            Buildings = null;  // Reset the building reference
        }
        else
        {
            Debug.Log("No building to sell!");
        }
    }
}
```
