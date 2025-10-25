using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // --- Variables (Ch 3) ---
    public int playerLevel = 5;
    private float health = 99.5f;
    public string playerName = "Srijit";
    private bool isAlive = true;

    void Start()
    {
        Debug.Log("Player name: " + playerName);
        Debug.LogFormat("Player {0} is level {1} with {2} health", playerName, playerLevel, health);

        // String interpolation
        Debug.Log($"Is {playerName} alive? {isAlive}");

        //  Methods
        int nextLevelXP = XpToLevelUp(playerLevel);
        Debug.Log($"XP needed for next level: {nextLevelXP}");

        // Conditionals
        if (playerLevel < 5)
        {
            Debug.Log("You are still a beginner!");
        }
        else if (playerLevel >= 5 && playerLevel < 10)
        {
            Debug.Log("You are getting stronger!");
        }
        else
        {
            Debug.Log("You are a master adventurer!");
        }

        // Testing true and !true
        if (isAlive)
        {
            Debug.Log("Player is alive and fighting!");
        }

        if (!isAlive)
        {
            Debug.Log("Player has fallen!");
        }

        // Nested if
        if (playerLevel > 3)
        {
            if (health > 50)
            {
                Debug.Log("You are ready for battle!");
            }
        }

        // Switch statement
        string weapon = "Sword";
        switch (weapon)
        {
            case "Bow":
                Debug.Log("You chose a ranged weapon.");
                break;
            case "Sword":
                Debug.Log("You chose a melee weapon.");
                break;
            default:
                Debug.Log("Unarmed... brave choice!");
                break;
        }

        // Collections 
        // Arrays
        int[] scores = { 10, 20, 30, 40, 50 };
        Debug.Log($"Second element in array: {scores[1]}"); // returns 20

        // Lists
        List<string> inventory = new List<string>() { "Sword", "Shield", "Potion", "Bow" };
        Debug.Log($"First item in inventory: {inventory[0]}");

        // Dictionary
        Dictionary<string, int> enemies = new Dictionary<string, int>()
        {
            { "Slime", 5 },
            { "Goblin", 10 },
            { "Dragon", 100 }
        };
        Debug.Log($"Dragon strength: {enemies["Dragon"]}");

        //  Loops 

        for (int i = 0; i < inventory.Count; i++)
        {
            if (i == 2)
            {
                Debug.Log($"for-loop specific index 2: {inventory[i]}");
            }
        }


        foreach (string item in inventory)
        {
            Debug.Log($"foreach-list item: {item}");
        }

        foreach (KeyValuePair<string, int> kvp in enemies)
        {
            Debug.Log($"enemy: {kvp.Key}, strength: {kvp.Value}");
        }


        //Ch 5

        Character hero = new Character("Aragon", 10);
        Character heroine = new Character("Eowyn", 8);

        hero.PrintStatsInfo();
        heroine.PrintStatsInfo();

        // Structs
        Weapon huntingBow = new Weapon("Hunting Bow", 25);
        Weapon warBow = new Weapon("War Bow", 40);

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        // Child Class (Inheritance)
        Paladin knight = new Paladin("Galahad", 12, new Weapon("Holy Sword", 75));
        knight.PrintStatsInfo();

        // Referencing GameObjects
        Transform cameraTransform = GetComponent<Transform>();
        Debug.Log($"Camera local position: {cameraTransform.localPosition}");

        GameObject lightObj = GameObject.Find("Directional Light");
        Transform lightTransform = lightObj.GetComponent<Transform>();
        Debug.Log($"Light local position: {lightTransform.localPosition}");
    }

    // Method Example
    int XpToLevelUp(int currentLevel)
    {
        int baseXP = 100;
        int xpRequired = baseXP * currentLevel;
        return xpRequired;
    }
}

