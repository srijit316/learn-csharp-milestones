using UnityEngine;

// --- Chapter 5: Working with Classes, Structs, and OOP ---
public class Character
{
    public string name;
    public int level;

    // Constructor
    public Character(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    // Virtual method so it can be overridden in child classes
    public virtual void PrintStatsInfo()
    {
        Debug.Log($"Character: {name}, Level: {level}");
    }
}

// --- Struct Example ---
public struct Weapon
{
    public string name;
    public int damage;

    // Constructor
    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.Log($"Weapon: {name}, Damage: {damage}");
    }
}

// --- Inheritance Example ---
public class Paladin : Character
{
    public Weapon weapon;

    // Constructor that calls base class constructor
    public Paladin(string name, int level, Weapon weapon) : base(name, level)
    {
        this.weapon = weapon;
    }

    // Override PrintStatsInfo to include weapon info
    public override void PrintStatsInfo()
    {
        Debug.Log($"Paladin: {name}, Level: {level}, Weapon: {weapon.name}, Damage: {weapon.damage}");
    }
}
